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
 * TODO: include komorebi-application-rules license once published
 *
 */

using Whim;
void ApplicationRules(IContext context)
{\
"""


def write_line(content, append=True, newlines=1):
    mode = 'a' if append else 'w'
    with open(_outfile, mode) as o:
        o.write(content + '\n' * newlines)


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
        write_line(CSX_HEADER, append=False)

    @staticmethod
    def footer():
        write_line('\n}')

    def parse_and_write_all_rules(self):
        for app in self.komorebi_rules:
            if "float_identifiers" in app:
                FloatRules(app["float_identifiers"], app["name"]).write_rules()


class FloatRules:
    def __init__(self, float_rules, name):
        self.name = name
        self.float_rules = float_rules

    def write_rules(self):
        write_line(''.join(('\n', ' ' * 4, '// ', self.name)))
        for r in self.float_rules:
            FloatRule(r).write_rule()


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

    def write_rule(self):
        match self.kind:
            case 'Class':
                command = 'AddWindowClassFilter'
            case 'Exe':
                command = 'AddProcessNameFilter'
            case 'Title':
                command = 'AddTitleFilter'
            case _:
                print('Undefined kind:' + self.kind)
        comment = '  // ' + self.comment if self.comment else ''
        content = ''.join(
            [' ' * 4, 'context.FilterManager.', command, '("', self.id, '");', comment])
        write_line(content)


# Load komorebi rules
rules = GetRules(_url)
rules.download()
rules.load()

# Parse rules and convert to FilterManager commands
parse = ParseRules(rules.rules)
parse.header()
parse.parse_and_write_all_rules()
parse.footer()
