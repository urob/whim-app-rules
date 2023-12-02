from pathlib import Path
from requests import get
import yaml

# set up paths
_root = Path(__file__).parents[0]
_outfile = _root / 'app_rules.csx'

# link to komorebi rules file
_url = 'https://raw.githubusercontent.com/LGUG2Z/komorebi-application-specific-configuration/master/applications.yaml'

CSX_HEADER = """\
/* Application Rules for Whim
 *
 * USAGE INSTRUCTIONS
 *
 * This file is intended to be included in whim.config.csx, adding the following two lines:
 *   #load "/path/to/app_rules.csx"  // add this near the top just below the #r directives
 *   ApplicationRules(context);      // add this anywhere inside the DoConfig void
 *
 * COPYRIGHT AND PERMISSION NOTICE
 *
 * This file was generated from data with the following license:
 *
 * MIT License
 *
 * Copyright (c) 2021 Jade Iqbal
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using Whim;
void ApplicationRules(IContext context)
{\
"""


def write(content, append=True, indent=True):
    mode = 'a' if append else 'w'
    indent = ' ' * 4 if indent else ''
    with open(_outfile, mode) as o:
        o.write(indent + content + '\n')


class GetRules:
    def __init__(self, url):
        self.url = url
        self.out = _root / 'temp_komorebi_rules.yaml'
        self.rules = None

    def download(self):
        response = get(self.url)
        with open(self.out, 'wb') as f:
            f.write(response.content)

    def load(self):
        with open(self.out, 'r') as f:
            self.rules = yaml.safe_load(f)


class ParseRules:
    def __init__(self, komorebi_rules):
        self.komorebi_rules = komorebi_rules

    @staticmethod
    def header():
        write(CSX_HEADER, append=False, indent=False)

    @staticmethod
    def footer():
        write('\n}', indent=False)

    def parse_and_write_all_rules(self):
        for app in self.komorebi_rules:
            if "float_identifiers" in app:
                FloatRules(app["float_identifiers"], app["name"]).write_rules()


class FloatRules:
    def __init__(self, float_rules, name):
        self.name = name
        self.float_rules = float_rules

    def write_rules(self):
        write('', indent=False)
        write('// ' + self.name)
        for r in self.float_rules:
            FloatRule(r).add_rule()


class FloatRule:
    def __init__(self, rule):
        self.kind = rule['kind']
        self.id = rule['id']
        self.matching_strategy = rule[_] if (_ := 'matching_strategy') in rule else None
        self.comment = rule[_] if (_ := 'comment') in rule else None

        # Check for future unsupported matching strategies
        # Note: if regex is ever used for Title, we can implement it via "AddTitleMatchFilter"
        if self.matching_strategy and self.matching_strategy != 'Equals':
            print('Matching strategy "{_}" unsupported')

    def add_rule(self):
        match self.kind:
            case 'Class':
                command = 'AddWindowClassFilter'
            case 'Exe':
                command = 'AddProcessFileNameFilter'
            case 'Title':
                command = 'AddTitleFilter'
            case _:
                print('Undefined kind:' + self.kind)
        # check for duplicates
        content = ''.join(['context.FilterManager.', command, '("', self.id, '");'])
        if self.id not in _processed[self.kind]:
            comment = '  // ' + self.comment if self.comment else ''
            write(content + comment)
            _processed[self.kind] += [self.id]
        else:
            write(' '.join(('//', content, ' // duplicate rule')))


_processed = {'Class': [], 'Exe': [], 'Title': []}

# Load komorebi rules
rules = GetRules(_url)
rules.download()
rules.load()

# Parse rules and convert to FilterManager commands
parse = ParseRules(rules.rules)
parse.header()
parse.parse_and_write_all_rules()
parse.footer()
