#define MyAppName "ContactApp"
#define MyAppVersion "1.0.0"
#define MyAppExeName "ContactsAppUI.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
AppId={{96B07277-657D-48EC-A420-A0F2832AF46A}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
DefaultDirName={autopf}\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
OutputDir=C:\Пользователи\Aldi\Рабочий стол
OutputBaseFilename=mysetup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Aldi\source\repos\ContactsApp\ContactsAppUI\ContactsAppUI\bin\Release\net6.0-windows\ContactsAppUI.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Aldi\source\repos\ContactsApp\ContactsAppUI\ContactsAppUI\bin\Release\net6.0-windows\ContactsApp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Aldi\source\repos\ContactsApp\ContactsAppUI\ContactsAppUI\bin\Release\net6.0-windows\ContactsAppUI.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Aldi\source\repos\ContactsApp\ContactsAppUI\ContactsAppUI\bin\Release\net6.0-windows\ContactsAppUI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Aldi\source\repos\ContactsApp\ContactsAppUI\ContactsAppUI\bin\Release\net6.0-windows\ContactsAppUI.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Aldi\source\repos\ContactsApp\ContactsAppUI\ContactsAppUI\bin\Release\net6.0-windows\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Aldi\source\repos\ContactsApp\ContactsAppUI\ContactsAppUI\bin\Release\net6.0-windows\contacts.json"; DestDir: "{app}"; Flags: ignoreversion

[Registry]
Root: HKCR; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKCR; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKCR; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKCR; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKCR; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
