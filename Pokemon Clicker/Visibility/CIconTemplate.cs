﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Clicker.Visibility
{
    public class CIconTemplate
    {
        public ObservableCollection<CIcon> icons { get; set; }

        public CIconTemplate()
        {
            icons = [];
        }

        public void LoadIcons(string path)
        {
            icons.Add(new CIcon(100, 100, "test.png"));
        }

        public void AddIcon(CIcon icon)
        {
            icons.Add(icon);
        }

        public ObservableCollection<CIcon> GetIcons()
        {
            return icons;
        }

        public CIcon FindIconByName(string name)
        {
            foreach (CIcon icon in icons)
            {
                if (icon.GetName() == name)
                {
                    return icon;
                }
            }

            return new CIcon(50, 50, "none");
        }
    }
}
