using System;
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

        public  ZohaButton(Size Size,Point Location,Color color)
        {
            this.Size = Size;
            this.Location = Location;
            this.BackColor = color;
        }
    }
}
