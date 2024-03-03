using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracktice_task_16
{
    public partial class Partickles : Form
    {
        List<Partickle> partickles;
        public Pen partPen;
        public Brush partBrush;
        public Graphics partickleGraf;
        bool settingsVisible;

        public Partickles()
        {
            InitializeComponent();
            partPen = new Pen(Color.Red, 1);
            partBrush = new SolidBrush(Color.SteelBlue);
            partickleGraf = this.CreateGraphics();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            settingsVisible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GenerateField();
        }

        private void GenerateField()
        {
            Random random = new Random();
            partickles = new List<Partickle>();
            Partickle partickle;

            int x, y, spx, spy;

            for (int i = 0; i < numberOfDots.Value; i++)
            {
                x = random.Next(this.Width - 24);
                y = random.Next(this.Height - 24);
                spx = random.Next(-2, 2);
                spy = random.Next(-2, 2);

                partickle = new Partickle(this, x, y, spx, spy);
                partickles.Add(partickle);
            }
            updTimer.Start();
        }

        private void updTimer_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < partickles.Count; i++)
            {
                partickles[i].CheckBorders(this);
                partickles[i].Update(this);
                partickles[i].Draw(partBrush, g);
                partickles[i].DrawLines(partickles, Convert.ToInt32(lineLenght.Value), 
                    partPen, g);
            };
            this.BackgroundImage = bmp;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (settingsVisible)
            {
                settingsVisible = false;
                label1.Visible = false;
                label2.Visible = false;
                numberOfDots.Visible = false;
                lineLenght.Visible = false;
                ApplieButton.Visible = false;
            }
            else
            {
                settingsVisible = true;
                label1.Visible = true;
                label2.Visible = true;
                numberOfDots.Visible = true;
                lineLenght.Visible = true;
                ApplieButton.Visible = true;
            }
        }

        private void ApplieButton_Click(object sender, EventArgs e)
        {
            GenerateField();
        }
    }
}
