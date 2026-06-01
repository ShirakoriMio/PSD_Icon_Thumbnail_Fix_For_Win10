# PSD_Icon_Thumbnail_Fix_For_Win10
Lightweight executable for Windows 10: fixes .psd file thumbnails in medium, large, and extra large view so they display the visual contents of the file and provide a "PS" icon over the file to easily identify projects in your Windows Explorer.
=========================================
PSD Thumbnail & Icon Overlay Fix, by Shirakori Mio
Special thanks to Agamnentzar for the foundational 
thumbnail provider logic that makes PSD previews 
possible in Windows Explorer. See their github:
https://github.com/Agamnentzar/psd-thumbnail-provider

=========================================

DESCRIPTION:
This package installs a custom pipeline to force Windows to generate thumbnails for .psd files, and injects a custom native C# COM overlay to stamp a high-res Photoshop icon in the corner (bypassing the Windows 15-icon cloud limit).

HOW TO INSTALL:
1. Extract this entire folder to your Desktop (Do NOT run this while it is still zipped).
2. Right-click "Install_Fix.bat" and select "Run as Administrator".
3. A terminal window will open. If the Windows Installer pops up for the Thumbnail Provider, just click through it to install. 
4. The terminal will automatically copy the required files, register the custom DLL, wipe your icon cache, and restart your desktop.

NOTE: 
Because this script restarts Windows Explorer and injects a custom .dll into the registry, Windows Defender or your antivirus might throw a "Windows protected your PC" warning. Just click "More info" -> "Run anyway". 

Files included (Do not delete or rename these):
- Adobe_Photoshop_256.ico (The high-res icon)
- Install_Fix.bat (The master installation script)
- PsdOverlayNative.dll (The custom registry override)
- SharpShell.dll (Required .NET framework dependency)
- ThumbnailProvider.msi (The core image generator)
=========================================
