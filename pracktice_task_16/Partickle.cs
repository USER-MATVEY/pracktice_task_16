using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktice_task_16
{
    class Partickle
    {
        public int x, y;
        int xSpeed, ySpeed;

        public Partickle(Partickles form, int x, int y, int spx, int spy)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = spx;
            this.ySpeed = spy;
        }

        public void Draw(Brush brush, Graphics graphics)
        {
            graphics.FillEllipse(brush, this.x, this.y, 12, 12);
        }

        public void Update(Partickles form)
        {
            this.x += xSpeed;
            this.y += ySpeed;
        }

        public void CheckBorders(Partickles form) 
        {
            if (this.x <=  0) { this.xSpeed *= -1; }
            if (this.y <= 0) { this.ySpeed *= -1; }
            if (this.x + 36 >= form.Width) { this.xSpeed *= -1; }
            if (this.y + 54 >= form.Height) { this.ySpeed *= -1; }
        }

        public void DrawLines(List<Partickle> particles, int linelenght, Pen pen, Graphics graphics) 
        {
            for (int i = 0; i < particles.Count; i++)
            {
                if (
                    Math.Sqrt(Math.Pow(this.x - particles[i].x, 2) + 
                    Math.Pow(this.y - particles[i].y, 2)) <= linelenght)
                {
                    graphics.DrawLine(pen, new Point(this.x, this.y), new Point(particles[i].x, particles[i].y));
                }
            }
        }

    }
}
