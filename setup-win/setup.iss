; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Blockly4Thymio.v1.2"
#define MyAppExeName "compilateur.1.2.exe"
#define MyAppVersion "1.2"
#define MyAppPublisher "Okimi"
#define MyAppURL "http://www.blockly4thymio.net"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{E1148C13-AB58-426F-8469-2DB34F6A3832}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={sd}\{#MyAppName}
DefaultGroupName={#MyAppName}
InfoBeforeFile=texte-d-introduction.rtf
InfoAfterFile=fichiers\LISEZ-MOI.rtf
AllowNoIcons=yes
OutputDir=.
OutputBaseFilename=installation-{#MyAppName}
SetupIconFile=fichiers\blockly4thymio.ico
Compression=lzma
SolidCompression=yes
ChangesAssociations=yes
WizardImageFile=setup.bmp


[Registry]
Root: HKCR; Subkey: ".b4t";                             ValueData: "{#MyAppName}";          Flags: uninsdeletevalue; ValueType: string;  ValueName: ""
Root: HKCR; Subkey: "{#MyAppName}";                     ValueData: "{#MyAppName}";          Flags: uninsdeletekey;   ValueType: string;  ValueName: ""
Root: HKCR; Subkey: "{#MyAppName}\DefaultIcon";         ValueData: "{app}\{#MyAppExeName},0";                        ValueType: string;  ValueName: ""
Root: HKCR; Subkey: "{#MyAppName}\shell\open\command";  ValueData: """{app}\{#MyAppExeName}"" ""%1""";                ValueType: string;  ValueName: ""


[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"


[Files]
Source: "fichiers\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files


[Icons]
;Name: "{group}\Fichiers sons pour la carte SD"; Filename: "{app}\sons-pour-carte-micro-sd"
Name: "{group}\Dossier Blockly4Thymio"; Filename: "{app}"; IconFilename: "{app}\blockly4thymio-folder.ico"
Name: "{group}\Interface Blockly4Thymio"; Filename: "{app}\blockly4thymio-hors-ligne\Blockly4Thymio.html"; IconFilename: "{app}\blockly4thymio.ico"
Name: "{group}\Interface pour les Cycles 1"; Filename: "{app}\interface-cycle-1\index.html"; IconFilename: "{app}\blockly4thymio.ico"
Name: "{group}\Les exercices sur www.blockly4thymio.net"; Filename: "http://blockly4thymio.net/les-exercices.html"; IconFilename: "{app}\blockly4thymio.ico"
;Name: "{group}\Tester le compilateur"; Filename: "{app}\tester-le-compilateur.b4t"
;Name: "{group}\LISEZ-MOI"; Filename: "{app}\LISEZ-MOI.rtf"
;Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
;Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"


[Code]
function IsDotNetDetected(version: string; service: cardinal): boolean;
// Indicates whether the specified version and service pack of the .NET Framework is installed.
//
// version -- Specify one of these strings for the required .NET Framework version:
//    'v1.1'          .NET Framework 1.1
//    'v2.0'          .NET Framework 2.0
//    'v3.0'          .NET Framework 3.0
//    'v3.5'          .NET Framework 3.5
//    'v4\Client'     .NET Framework 4.0 Client Profile
//    'v4\Full'       .NET Framework 4.0 Full Installation
//    'v4.5'          .NET Framework 4.5
//    'v4.5.1'        .NET Framework 4.5.1
//    'v4.5.2'        .NET Framework 4.5.2
//    'v4.6'          .NET Framework 4.6
//    'v4.6.1'        .NET Framework 4.6.1
//
// service -- Specify any non-negative integer for the required service pack level:
//    0               No service packs required
//    1, 2, etc.      Service pack 1, 2, etc. required
var
    key, versionKey: string;
    install, release, serviceCount, versionRelease: cardinal;
    success: boolean;
begin
    versionKey := version;
    versionRelease := 0;

    // .NET 1.1 and 2.0 embed release number in version key
    if version = 'v1.1' then begin
        versionKey := 'v1.1.4322';
    end else if version = 'v2.0' then begin
        versionKey := 'v2.0.50727';
    end

    // .NET 4.5 and newer install as update to .NET 4.0 Full
    else if Pos('v4.', version) = 1 then begin
        versionKey := 'v4\Full';
        case version of
          'v4.5':   versionRelease := 378389;
          'v4.5.1': versionRelease := 378675; // or 378758 on Windows 8 and older
          'v4.5.2': versionRelease := 379893;
          'v4.6':   versionRelease := 393295; // or 393297 on Windows 8.1 and older
          'v4.6.1': versionRelease := 394254; // or 394271 on Windows 8.1 and older
        end;
    end;

    // installation key group for all .NET versions
    key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\' + versionKey;

    // .NET 3.0 uses value InstallSuccess in subkey Setup
    if Pos('v3.0', version) = 1 then begin
        success := RegQueryDWordValue(HKLM, key + '\Setup', 'InstallSuccess', install);
    end else begin
        success := RegQueryDWordValue(HKLM, key, 'Install', install);
    end;

    // .NET 4.0 and newer use value Servicing instead of SP
    if Pos('v4', version) = 1 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Servicing', serviceCount);
    end else begin
        success := success and RegQueryDWordValue(HKLM, key, 'SP', serviceCount);
    end;

    // .NET 4.5 and newer use additional value Release
    if versionRelease > 0 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Release', release);
        success := success and (release >= versionRelease);
    end;

    result := success and (install = 1) and (serviceCount >= service);
end;


// Fonction appel�e au lancement du Setup.exe
function InitializeSetup(): Boolean;
begin 
  if not ( IsDotNetDetected('v3.0', 0) or IsDotNetDetected('v4.0', 0) or IsDotNetDetected('v4.5', 0) ) then begin
    MsgBox('Le compilateur de Blockly4Thymio utilise'#13'Microsoft .NET Framework 3.0.'#13#13
        'Merci d''installer Microsoft .NET Framework (version 3.0 minimum)'#13
        'avant de relancer l''installation.', mbInformation, MB_OK);
    result := false;
  end else
    result := true;
end;
