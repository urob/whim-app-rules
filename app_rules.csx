// Application Rules

// 1Password
context.FilterManager.AddProcessNameFilter("1Password.exe");

// Ableton Live
context.FilterManager.AddWindowClassFilter("AbletonVstPlugClass");  // Targets VST2 windows
context.FilterManager.AddWindowClassFilter("Vst3PlugWindow");  // Targets VST3 windows

// Affinity Photo 2
context.FilterManager.AddProcessNameFilter("Photo.exe");

// AutoHotkey
context.FilterManager.AddTitleFilter("Window Spy");
context.FilterManager.AddProcessNameFilter("AutoHotkeyUX.exe");

// Bloxstrap
context.FilterManager.AddProcessNameFilter("Bloxstrap.exe");

// Calculator
context.FilterManager.AddTitleFilter("Calculator");

// Citrix Receiver
context.FilterManager.AddProcessNameFilter("SelfService.exe");

// Credential Manager UI Host
context.FilterManager.AddProcessNameFilter("CredentialUIBroker.exe");  // Targets the Windows popup prompting you for a PIN instead of a password on 1Password etc.

// Delphi applications
context.FilterManager.AddWindowClassFilter("TApplication");  // Target hidden window spawned by Delphi applications
context.FilterManager.AddWindowClassFilter("TWizardForm");  // Target Inno Setup installers

// Dropbox
context.FilterManager.AddProcessNameFilter("Dropbox.exe");

// Elephicon
context.FilterManager.AddProcessNameFilter("Elephicon.exe");

// Elgato Camera Hub
context.FilterManager.AddProcessNameFilter("Camera Hub.exe");

// Elgato Control Center
context.FilterManager.AddProcessNameFilter("ControlCenter.exe");

// Elgato Wave Link
context.FilterManager.AddProcessNameFilter("WaveLink.exe");

// GOG Galaxy
context.FilterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // Targets a hidden window spawned by GOG Galaxy

// Google Drive
context.FilterManager.AddProcessNameFilter("GoogleDriveFS.exe");

// IntelliJ IDEA
context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and floating windows

// Keyviz
context.FilterManager.AddProcessNameFilter("keyviz.exe");

// Logi Bolt
context.FilterManager.AddProcessNameFilter("LogiBolt.exe");

// LogiTune
context.FilterManager.AddProcessNameFilter("LogiTune.exe");

// Logitech Options
context.FilterManager.AddProcessNameFilter("LogiOptionsUI.exe");

// Microsoft Active Accessibility
context.FilterManager.AddWindowClassFilter("#32770");  // Dialog Box

// Microsoft Excel
context.FilterManager.AddWindowClassFilter("_WwB");  // Targets a hidden window spawned by Microsoft Office applications

// Microsoft Outlook
context.FilterManager.AddWindowClassFilter("_WwB");  // Targets a hidden window spawned by Microsoft Office applications

// Microsoft PC Manager
context.FilterManager.AddProcessNameFilter("MSPCManager.exe");

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
context.FilterManager.AddProcessNameFilter("NohBoard.exe");

// OneDrive
context.FilterManager.AddWindowClassFilter("OneDriveReactNativeWin32WindowClass");

// Paradox Launcher
context.FilterManager.AddProcessNameFilter("Paradox Launcher.exe");

// Playnite
context.FilterManager.AddProcessNameFilter("Playnite.FullscreenApp.exe");  // Target fullscreen app

// PowerToys
context.FilterManager.AddProcessNameFilter("PowerToys.ColorPickerUI.exe");  // Target color picker dialog
context.FilterManager.AddProcessNameFilter("PowerToys.ImageResizer.exe");  // Target image resizer dialog
context.FilterManager.AddProcessNameFilter("PowerToys.Peek.UI.exe");  // Target Peek popup

// Process Hacker
context.FilterManager.AddProcessNameFilter("ProcessHacker.exe");

// PyCharm
context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and detached windows

// QQ
context.FilterManager.AddTitleFilter("图片查看器");
context.FilterManager.AddTitleFilter("群聊的聊天记录");
context.FilterManager.AddTitleFilter("语音通话");

// QuickLook
context.FilterManager.AddProcessNameFilter("QuickLook.exe");

// RepoZ
context.FilterManager.AddProcessNameFilter("RepoZ.exe");

// Rider
context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and floating windows
context.FilterManager.AddTitleFilter("PopupMessageWindow");  // Targets JetBrains IDE popups

// RoundedTB
context.FilterManager.AddProcessNameFilter("RoundedTB.exe");

// RustRover
context.FilterManager.AddWindowClassFilter("SunAwtDialog");  // Targets JetBrains IDE popups and floating windows

// Sideloadly
context.FilterManager.AddProcessNameFilter("sideloadly.exe");

// Slack
context.FilterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // Targets a hidden window spawned by Slack

// Slack
context.FilterManager.AddWindowClassFilter("Chrome_RenderWidgetHostHWND");  // Targets a hidden window spawned by Slack

// Smart Install Maker
context.FilterManager.AddWindowClassFilter("obj_App");  // Target hidden window spawned by installer
context.FilterManager.AddWindowClassFilter("obj_Form");  // Target installer

// SnippingTool
context.FilterManager.AddProcessNameFilter("SnippingTool.exe");

// Steam Beta
context.FilterManager.AddTitleFilter("notificationtoasts_");  // Target notification toast popups

// System Informer
context.FilterManager.AddProcessNameFilter("SystemInformer.exe");

// SystemSettings
context.FilterManager.AddWindowClassFilter("Shell_Dialog");

// Task Manager
context.FilterManager.AddWindowClassFilter("TaskManagerWindow");

// TouchCursor
context.FilterManager.AddProcessNameFilter("tcconfig.exe");

// TranslucentTB
context.FilterManager.AddProcessNameFilter("TranslucentTB.exe");

// WinZip (32-bit)
context.FilterManager.AddProcessNameFilter("winzip32.exe");

// WinZip (64-bit)
context.FilterManager.AddProcessNameFilter("winzip64.exe");

// Windows Explorer
context.FilterManager.AddWindowClassFilter("OperationStatusWindow");  // Targets copy/move operation windows
context.FilterManager.AddTitleFilter("Control Panel");

// Windows Installer
context.FilterManager.AddProcessNameFilter("msiexec.exe");

// Windows Subsystem for Android
context.FilterManager.AddWindowClassFilter("android(splash)");  // Targets splash/startup screen

// Wox
context.FilterManager.AddTitleFilter("Hotkey sink");  // Targets a hidden window spawned by Wox

// Zoom
context.FilterManager.AddProcessNameFilter("Zoom.exe");

// paint.net
context.FilterManager.AddProcessNameFilter("paintdotnet.exe");

// pinentry
context.FilterManager.AddProcessNameFilter("pinentry.exe");

// ueli
context.FilterManager.AddProcessNameFilter("ueli.exe");

