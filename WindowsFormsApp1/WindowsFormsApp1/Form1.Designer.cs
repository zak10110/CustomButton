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

        private void Button_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var draw = button.CreateGraphics();
            draw.FillRectangle(Brushes.DarkSeaGreen,new Rectangle(10,10,button.Size.Width-20,button.Size.Height-20));
            //draw.FillEllipse(Brushes.DarkCyan, new Rectangle(15, 15, (button.Size.Width-20/2), button.Size.Height - 20));

        }

        private void Button_Click(object sender, System.EventArgs e)
        {
           




        }

        ZohaButton button;

        #endregion
    }
}

