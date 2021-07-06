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

        readonly int step = 10;
        readonly int step2 = 11;
        int ElipsCoordX = 11;
        readonly  int step3 = 21;
        readonly int two = 2;
        readonly  int six = 6;
        bool Ison = true;
        SolidBrush brush = new SolidBrush(Color.DarkSeaGreen);
        Color red = Color.PaleVioletRed;
        Color green = Color.DarkSeaGreen;
        Color Aqua = Color.Aquamarine;

        public  ZohaButton(Size Size,Point Location,Color color):this()
        {
            this.Size = Size;
            this.Location = Location;
            this.BackColor = color;
        }

        public ZohaButton() 
        {
            this.Click += ButtonChange;
            this.Paint += Button_Peint;


        }


        private void ButtonChange(object sender, System.EventArgs e)
        {
            Ison = !Ison;
            brush.Color = (Ison) ? green : red;
            ElipsCoordX = (Ison) ? this.Size.Width - (step * six) : step2;
            this.Invalidate();


        }


        private void Button_Peint(object sender, System.EventArgs e)
        {
            var draw = this.CreateGraphics();
            draw.FillRectangle(brush, new Rectangle(step, step, this.Size.Width - (step * two), this.Size.Height - (step * two)));
            draw.FillEllipse(Brushes.Aqua, new Rectangle(ElipsCoordX, step2, ((this.Size.Width - (step * step)) / two), ((this.Size.Height - step3))));

        }
    }
}
