using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Layout;
using Avalonia.Media;
using System.Xml.Linq;
using System;
using Avalonia.Media.Imaging;

namespace Pokemon_Clicker.Visibility
{
    public class CIcon
    {
        private string Name { get; set; }
        private string iconPath;
        private int iconWidth;
        private int iconHeight;

        public CIcon(int iconWidth, int iconHeight, string iconPath)
        {
            this.iconWidth = iconWidth;
            this.iconHeight = iconHeight;
            this.iconPath = iconPath;
            Name = iconPath.Substring(0, iconPath.IndexOf("."));
        }

        public string GetPath()
        {
            return iconPath;
        }

        public string GetName()
        {
            return Name;
        }
    }
}

