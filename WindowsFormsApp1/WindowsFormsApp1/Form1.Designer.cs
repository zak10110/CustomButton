using System.Drawing;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        int step = 10;
        int step2 = 11;
        int ElipsCoordX = 11;
        bool Ison = true;
        SolidBrush brush = new SolidBrush(Color.DarkSeaGreen);
        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            button = new ZohaButton(new System.Drawing.Size(200,70),new System.Drawing.Point(100,100),Color.DarkCyan);
            button.Click += Button_Click;
            button.Paint += Button_Paint;

            this.Controls.Add(button);


        }

       

        private void Button_Click(object sender, System.EventArgs e)
        {
            Ison = !Ison;
            brush.Color = (Ison) ? Color.DarkSeaGreen : Color.PaleVioletRed;
            ElipsCoordX =(Ison)? button.Size.Width - (step*6):step2;
            button.Invalidate();


        }


        private void Button_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var draw = button.CreateGraphics();
            draw.FillRectangle(brush, new Rectangle(step, step, button.Size.Width - (step * 2), button.Size.Height - (step * 2)));
            draw.FillEllipse(Brushes.Aquamarine, new Rectangle(ElipsCoordX, step2, ((button.Size.Width - (step * 10)) / 2), ((button.Size.Height - 21))));

        }

        ZohaButton button;

        #endregion
    }
}

