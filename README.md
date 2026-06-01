# PSD_Icon_Thumbnail_Fix_For_Win10
Lightweight executable for Windows 10: fixes .psd file thumbnails in medium, large, and extra large view so they display the visual contents of the file and provide a "PS" icon over the file to easily identify projects in your Windows Explorer.

=========================================
PSD Thumbnail & Icon Overlay Fix, by Shirakori Mio
Special thanks to Agamnentzar for the foundational thumbnail provider logic that makes PSD previews possible in Windows Explorer. 
See their github: https://github.com/Agamnentzar/psd-thumbnail-provider

=========================================

DESCRIPTION:
This package installs a custom pipeline to force Windows to generate thumbnails for .psd files and injects a custom native C# COM overlay to stamp a high-res Photoshop icon in the corner (bypassing the Windows 15-icon overlay limit).

HOW TO INSTALL:
1. Download "PSD_Icon_Thumbnail_Fix_For_Win10.exe" from the Releases section.
2. Right-click the file and select "Run as Administrator".
3. The installer will automatically extract the files, install the thumbnail provider, register the custom overlay, wipe your icon cache, and restart Windows Explorer to apply the changes.

🛡️ SECURITY NOTE:
Because this is a free, open-source tool and not signed with a commercial certificate, Windows may trigger a "Windows protected your PC" (SmartScreen) warning when you run the installer. To bypass this, click "More info" on the warning window, then click "Run anyway". 

You can verify the safety of this installer by reviewing the open-source code provided in this repository.

=========================================
