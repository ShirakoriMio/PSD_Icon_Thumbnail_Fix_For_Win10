using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using SharpShell.Attributes;
using SharpShell.Interop;
using SharpShell.SharpIconOverlayHandler;

namespace PsdOverlayNative
{
    [ComVisible(true)]
    [Guid("A1B2C3D4-E5F6-47A8-9B0C-1D2E3F4A5B6C")] // Locks the registry identity
    [DisplayName("   PsdIconOverlay")] // 3 spaces to guarantee the #1 slot
    public class PsdOverlay : SharpIconOverlayHandler
    {
        private Icon _psIcon;

        protected override bool CanShowOverlay(string path, FILE_ATTRIBUTE attributes)
        {
            try
            {
                return Path.GetExtension(path)?.ToLower() == ".psd";
            }
            catch
            {
                return false;
            }
        }

        protected override Icon GetOverlayIcon()
        {
            if (_psIcon == null)
            {
                // Dynamically gets the exact folder where this DLL is installed
                string dllDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                // Looks for the icon in that exact same folder
                string customIconPath = Path.Combine(dllDirectory, "Adobe_Photoshop_256.ico");

                if (File.Exists(customIconPath))
                {
                    _psIcon = new Icon(customIconPath);
                }
            }
            return _psIcon;
        }

        protected override int GetPriority()
        {
            return 0; // Highest priority
        }
    }
}