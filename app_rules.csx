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
{

    // 1Password
    context.FilterManager.AddProcessNameFilter("1Password");

    // Ableton Live
    context.FilterManager.AddWindowClassFilter("AbletonVstPlugClass");  // Targets VST2 windows
    context.FilterManager.AddWindowClassFilter("Vst3PlugWindow");  // Targets VST3 windows

    // Affinity Photo 2
    context.FilterManager.AddProcessNameFilter("Photo");

    // AutoHotkey
    context.FilterManager.AddTitleFilter("Window Spy");
    context.FilterManager.AddProcessNameFilter("AutoHotkeyUX");

    // Bloxstrap
    context.FilterManager.AddProcessNameFilter("Bloxstrap");

    // Calculator
    context.FilterManager.AddTitleFilter("Calculator");

    // Citrix Receiver
    context.FilterManager.AddProcessNameFilter("SelfService");

    // Credential Manager UI Host
    context.FilterManager.AddProcessNameFilter("CredentialUIBroker");  // Targets the Windows popup prompting you for a PIN instead of a password on 1Password etc.

    // Delphi applications
    context.FilterManager.AddWindowClassFilter("TApplication");  // Target hidden window spawned by Delphi applications
    context.FilterManager.AddWindowClassFilter("TWizardForm");  // Target Inno Setup installers

    // Dropbox
    context.FilterManager.AddProcessNameFilter("Dropbox");

    // Elephicon
    context.FilterManager.AddProcessNameFilter("Elephicon");

    // Elgato Camera Hub
    context.FilterManager.AddProcessNameFilter("Camera Hub");

    // Elgato Control Center
    context.FilterManager.AddProcessNameFilter("ControlCenter");

    // Elgato Wave Link
    context.FilterManager.AddProcessNameFilter("WaveLink");

    // GOG Galaxy
    context.FilterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // Targets a hidden window spawned by GOG Galaxy

    // Google Drive
    context.FilterManager.AddProcessNameFilter("GoogleDriveFS");

    // IntelliJ IDEA
    context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and floating windows

    // Keyviz
    context.FilterManager.AddProcessNameFilter("keyviz");

    // Logi Bolt
    context.FilterManager.AddProcessNameFilter("LogiBolt");

    // LogiTune
    context.FilterManager.AddProcessNameFilter("LogiTune");

    // Logitech Options
    context.FilterManager.AddProcessNameFilter("LogiOptionsUI");

    // Microsoft Active Accessibility
    context.FilterManager.AddWindowClassFilter("#32770");  // Dialog Box

    // Microsoft Excel
    context.FilterManager.AddWindowClassFilter("_WwB");  // Targets a hidden window spawned by Microsoft Office applications

    // Microsoft Outlook
    context.FilterManager.AddWindowClassFilter("_WwB");  // Targets a hidden window spawned by Microsoft Office applications

    // Microsoft PC Manager
    context.FilterManager.AddProcessNameFilter("MSPCManager");

    // Microsoft PowerPoint
    context.FilterManager.AddWindowClassFilter("_WwB");  // Targets a hidden window spawned by Microsoft Office applications

    // Microsoft Teams classic
    context.FilterManager.AddTitleFilter("Microsoft Teams Notification");  // Target Teams pop-up notification windows
    context.FilterManager.AddTitleFilter("Microsoft Teams Call");  // Target Teams call in progress windows

    // Microsoft Word
    context.FilterManager.AddWindowClassFilter("_WwB");  // Targets a hidden window spawned by Microsoft Office applications

    // Mozilla Firefox
    context.FilterManager.AddWindowClassFilter("MozillaTaskbarPreviewClass");  // Targets invisible windows spawned by Firefox to show tab previews in the taskbar

    // NohBoard
    context.FilterManager.AddProcessNameFilter("NohBoard");

    // OneDrive
    context.FilterManager.AddWindowClassFilter("OneDriveReactNativeWin32WindowClass");

    // Paradox Launcher
    context.FilterManager.AddProcessNameFilter("Paradox Launcher");

    // Playnite
    context.FilterManager.AddProcessNameFilter("Playnite.FullscreenApp");  // Target fullscreen app

    // PowerToys
    context.FilterManager.AddProcessNameFilter("PowerToys.ColorPickerUI");  // Target color picker dialog
    context.FilterManager.AddProcessNameFilter("PowerToys.ImageResizer");  // Target image resizer dialog
    context.FilterManager.AddProcessNameFilter("PowerToys.Peek.UI");  // Target Peek popup

    // Process Hacker
    context.FilterManager.AddProcessNameFilter("ProcessHacker");

    // PyCharm
    context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and detached windows

    // QQ
    context.FilterManager.AddTitleFilter("图片查看器");
    context.FilterManager.AddTitleFilter("群聊的聊天记录");
    context.FilterManager.AddTitleFilter("语音通话");

    // QuickLook
    context.FilterManager.AddProcessNameFilter("QuickLook");

    // RepoZ
    context.FilterManager.AddProcessNameFilter("RepoZ");

    // Rider
    context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and floating windows
    context.FilterManager.AddTitleFilter("PopupMessageWindow");  // Targets JetBrains IDE popups

    // RoundedTB
    context.FilterManager.AddProcessNameFilter("RoundedTB");

    // RustRover
    context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and floating windows

    // Sideloadly
    context.FilterManager.AddProcessNameFilter("sideloadly");

    // Slack
    context.FilterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // Targets a hidden window spawned by Slack

    // Slack
    context.FilterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // Targets a hidden window spawned by Slack

    // Smart Install Maker
    context.FilterManager.AddWindowClassFilter("obj_App");  // Target hidden window spawned by installer
    context.FilterManager.AddWindowClassFilter("obj_Form");  // Target installer

    // SnippingTool
    context.FilterManager.AddProcessNameFilter("SnippingTool");

    // Steam Beta
    context.FilterManager.AddTitleFilter("notificationtoasts_");  // Target notification toast popups

    // System Informer
    context.FilterManager.AddProcessNameFilter("SystemInformer");

    // SystemSettings
    context.FilterManager.AddWindowClassFilter("Shell_Dialog");

    // Task Manager
    context.FilterManager.AddWindowClassFilter("TaskManagerWindow");

    // TouchCursor
    context.FilterManager.AddProcessNameFilter("tcconfig");

    // TranslucentTB
    context.FilterManager.AddProcessNameFilter("TranslucentTB");

    // WinZip (32-bit)
    context.FilterManager.AddProcessNameFilter("winzip32");

    // WinZip (64-bit)
    context.FilterManager.AddProcessNameFilter("winzip64");

    // Windows Explorer
    context.FilterManager.AddWindowClassFilter("OperationStatusWindow");  // Targets copy/move operation windows
    context.FilterManager.AddTitleFilter("Control Panel");

    // Windows Installer
    context.FilterManager.AddProcessNameFilter("msiexec");

    // Windows Subsystem for Android
    context.FilterManager.AddWindowClassFilter("android(splash)");  // Targets splash/startup screen

    // Wox
    context.FilterManager.AddTitleFilter("Hotkey sink");  // Targets a hidden window spawned by Wox

    // Zoom
    context.FilterManager.AddProcessNameFilter("Zoom");

    // paint.net
    context.FilterManager.AddProcessNameFilter("paintdotnet");

    // pinentry
    context.FilterManager.AddProcessNameFilter("pinentry");

    // ueli
    context.FilterManager.AddProcessNameFilter("ueli");

}
