﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ZohaButton:Control
    {

        public Size size;
        public Point location;

        public  ZohaButton(Size Size,Point Location)
        {
            this.size = Size;
            this.location = Location;
        }
    }
}
