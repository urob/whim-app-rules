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
{
    // Small file change to test automatic updating via GHA

    // 1Password
    context.FilterManager.AddProcessFileNameFilter("1Password.exe");

    // Ableton Live
    context.FilterManager.AddWindowClassFilter("AbletonVstPlugClass");  // Targets VST2 windows
    context.FilterManager.AddWindowClassFilter("Vst3PlugWindow");  // Targets VST3 windows

    // Affinity Photo 2
    context.FilterManager.AddProcessFileNameFilter("Photo.exe");

    // AutoHotkey
    context.FilterManager.AddTitleFilter("Window Spy");
    context.FilterManager.AddProcessFileNameFilter("AutoHotkeyUX.exe");

    // Bloxstrap
    context.FilterManager.AddProcessFileNameFilter("Bloxstrap.exe");

    // Calculator
    context.FilterManager.AddTitleFilter("Calculator");

    // Citrix Receiver
    context.FilterManager.AddProcessFileNameFilter("SelfService.exe");

    // Credential Manager UI Host
    context.FilterManager.AddProcessFileNameFilter("CredentialUIBroker.exe");  // Targets the Windows popup prompting you for a PIN instead of a password on 1Password etc.

    // Delphi applications
    context.FilterManager.AddWindowClassFilter("TApplication");  // Target hidden window spawned by Delphi applications
    context.FilterManager.AddWindowClassFilter("TWizardForm");  // Target Inno Setup installers

    // Dropbox
    context.FilterManager.AddProcessFileNameFilter("Dropbox.exe");

    // Elephicon
    context.FilterManager.AddProcessFileNameFilter("Elephicon.exe");

    // Elgato Camera Hub
    context.FilterManager.AddProcessFileNameFilter("Camera Hub.exe");

    // Elgato Control Center
    context.FilterManager.AddProcessFileNameFilter("ControlCenter.exe");

    // Elgato Wave Link
    context.FilterManager.AddProcessFileNameFilter("WaveLink.exe");

    // GOG Galaxy
    context.FilterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // Targets a hidden window spawned by GOG Galaxy

    // Google Drive
    context.FilterManager.AddProcessFileNameFilter("GoogleDriveFS.exe");

    // IntelliJ IDEA
    context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and floating windows

    // Keyviz
    context.FilterManager.AddProcessFileNameFilter("keyviz.exe");

    // Logi Bolt
    context.FilterManager.AddProcessFileNameFilter("LogiBolt.exe");

    // LogiTune
    context.FilterManager.AddProcessFileNameFilter("LogiTune.exe");

    // Logitech Options
    context.FilterManager.AddProcessFileNameFilter("LogiOptionsUI.exe");

    // Microsoft Active Accessibility
    context.FilterManager.AddWindowClassFilter("#32770");  // Dialog Box

    // Microsoft Excel
    context.FilterManager.AddWindowClassFilter("_WwB");  // Targets a hidden window spawned by Microsoft Office applications

    // Microsoft Outlook
    // context.FilterManager.AddWindowClassFilter("_WwB");  // duplicate rule

    // Microsoft PC Manager
    context.FilterManager.AddProcessFileNameFilter("MSPCManager.exe");

    // Microsoft PowerPoint
    // context.FilterManager.AddWindowClassFilter("_WwB");  // duplicate rule

    // Microsoft Teams classic
    context.FilterManager.AddTitleFilter("Microsoft Teams Notification");  // Target Teams pop-up notification windows
    context.FilterManager.AddTitleFilter("Microsoft Teams Call");  // Target Teams call in progress windows

    // Microsoft Word
    // context.FilterManager.AddWindowClassFilter("_WwB");  // duplicate rule

    // Mozilla Firefox
    context.FilterManager.AddWindowClassFilter("MozillaTaskbarPreviewClass");  // Targets invisible windows spawned by Firefox to show tab previews in the taskbar

    // NohBoard
    context.FilterManager.AddProcessFileNameFilter("NohBoard.exe");

    // OneDrive
    context.FilterManager.AddWindowClassFilter("OneDriveReactNativeWin32WindowClass");

    // Paradox Launcher
    context.FilterManager.AddProcessFileNameFilter("Paradox Launcher.exe");

    // Playnite
    context.FilterManager.AddProcessFileNameFilter("Playnite.FullscreenApp.exe");  // Target fullscreen app

    // PowerToys
    context.FilterManager.AddProcessFileNameFilter("PowerToys.ColorPickerUI.exe");  // Target color picker dialog
    context.FilterManager.AddProcessFileNameFilter("PowerToys.ImageResizer.exe");  // Target image resizer dialog
    context.FilterManager.AddProcessFileNameFilter("PowerToys.Peek.UI.exe");  // Target Peek popup

    // Process Hacker
    context.FilterManager.AddProcessFileNameFilter("ProcessHacker.exe");

    // PyCharm
    // context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule

    // QQ
    context.FilterManager.AddTitleFilter("图片查看器");
    context.FilterManager.AddTitleFilter("群聊的聊天记录");
    context.FilterManager.AddTitleFilter("语音通话");

    // QuickLook
    context.FilterManager.AddProcessFileNameFilter("QuickLook.exe");

    // RepoZ
    context.FilterManager.AddProcessFileNameFilter("RepoZ.exe");

    // Rider
    // context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule
    context.FilterManager.AddTitleFilter("PopupMessageWindow");  // Targets JetBrains IDE popups

    // RoundedTB
    context.FilterManager.AddProcessFileNameFilter("RoundedTB.exe");

    // RustRover
    // context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // duplicate rule

    // Sideloadly
    context.FilterManager.AddProcessFileNameFilter("sideloadly.exe");

    // Slack
    // context.FilterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // duplicate rule

    // Slack
    // context.FilterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // duplicate rule

    // Smart Install Maker
    context.FilterManager.AddWindowClassFilter("obj_App");  // Target hidden window spawned by installer
    context.FilterManager.AddWindowClassFilter("obj_Form");  // Target installer

    // SnippingTool
    context.FilterManager.AddProcessFileNameFilter("SnippingTool.exe");

    // Steam Beta
    context.FilterManager.AddTitleFilter("notificationtoasts_");  // Target notification toast popups

    // System Informer
    context.FilterManager.AddProcessFileNameFilter("SystemInformer.exe");

    // SystemSettings
    context.FilterManager.AddWindowClassFilter("Shell_Dialog");

    // Task Manager
    context.FilterManager.AddWindowClassFilter("TaskManagerWindow");

    // TouchCursor
    context.FilterManager.AddProcessFileNameFilter("tcconfig.exe");

    // TranslucentTB
    context.FilterManager.AddProcessFileNameFilter("TranslucentTB.exe");

    // WinZip (32-bit)
    context.FilterManager.AddProcessFileNameFilter("winzip32.exe");

    // WinZip (64-bit)
    context.FilterManager.AddProcessFileNameFilter("winzip64.exe");

    // Windows Explorer
    context.FilterManager.AddWindowClassFilter("OperationStatusWindow");  // Targets copy/move operation windows
    context.FilterManager.AddTitleFilter("Control Panel");

    // Windows Installer
    context.FilterManager.AddProcessFileNameFilter("msiexec.exe");

    // Windows Subsystem for Android
    context.FilterManager.AddWindowClassFilter("android(splash)");  // Targets splash/startup screen

    // Wox
    context.FilterManager.AddTitleFilter("Hotkey sink");  // Targets a hidden window spawned by Wox

    // Zoom
    context.FilterManager.AddProcessFileNameFilter("Zoom.exe");

    // paint.net
    context.FilterManager.AddProcessFileNameFilter("paintdotnet.exe");

    // pinentry
    context.FilterManager.AddProcessFileNameFilter("pinentry.exe");

    // ueli
    context.FilterManager.AddProcessFileNameFilter("ueli.exe");

}
