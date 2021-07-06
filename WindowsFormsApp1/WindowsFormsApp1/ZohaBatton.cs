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

        int step = 10;
        int step2 = 11;
        int ElipsCoordX = 11;
        bool Ison = true;
        SolidBrush brush = new SolidBrush(Color.DarkSeaGreen);

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
            brush.Color = (Ison) ? Color.DarkSeaGreen : Color.PaleVioletRed;
            ElipsCoordX = (Ison) ? this.Size.Width - (step * 6) : step2;
            this.Invalidate();


        }


        private void Button_Peint(object sender, System.EventArgs e)
        {
            var draw = this.CreateGraphics();
            draw.FillRectangle(brush, new Rectangle(step, step, this.Size.Width - (step * 2), this.Size.Height - (step * 2)));
            draw.FillEllipse(Brushes.Aquamarine, new Rectangle(ElipsCoordX, step2, ((this.Size.Width - (step * 10)) / 2), ((this.Size.Height - 21))));

        }
    }
}
