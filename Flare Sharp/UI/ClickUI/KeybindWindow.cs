﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.ClientBase.Modules;
using Flare_Sharp.UI.ClickUI.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.UI.ClickUI
{
    public class KeybindWindow : CUIWindow
    {
        public KeybindWindow(Category cat)
        {
            this.width = 200;
            controls.Add(new CUILabel(cat.name, "Arial", 32, FontStyle.Underline, Color.FromArgb(255, 255, 255), 10, 10, this));
            byte Z = 0;
            foreach (Module mod in cat.modules)
            {
                controls.Add(new CUIModuleItem(mod, Color.FromArgb(0, 0, 0), 0, (Z * 20) + 50, this));
                Z++;
            }
            visible = true;
            this.height = 64 + (Z * 20);
        }
    }
}