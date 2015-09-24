using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duckhunt
{
    public partial class FormView : Form
    {
        private int x;
        private int y;
        private double heading;
        private int direction;
        private int width = 30;
        private int height = 30;
        private Stack<Point> clickStack;
        private Random rnd = new Random();

        public FormView()
        {
            InitializeComponent();

            heading = 1.5;
            direction = 1;
            x = 00;
            y = 50;

            clickStack = new Stack<Point>();
            
        }

        public void UpdateView()
        {
            MoveUnit();
            Console.WriteLine("UpdateView");

            if (clickStack.Count > 0)
            {
                if (CheckClickCollision(clickStack.Pop()))
                {
                    Console.WriteLine("COLLISION !!!!");
                    x = rnd.Next(1, (this.Size.Width - width * 2));
                    y = rnd.Next(1, (this.Size.Height - height * 2));
                    //remove moving object
                }
            }

            Invalidate();
            
        }

        private void MoveUnit()
        {
            int windowHeight = this.Size.Height;
            int windowWidth = this.Size.Width;

            if ((x + width) >= windowWidth)
            {
                direction = -1;
            }
            else if (x <= 0)
            {
                direction = 1;
            }

            /*if((y + height) >= height)
            {

            }*/

            x = x + (1 * direction);
        }


        private bool CheckClickCollision(Point location)
        {
            bool collision = false;

            if ((location.X > x) && (location.X < (x + 30)) && (location.Y > y) && (location.Y < (y + 30)))
            {
                collision = true;
            }

            return collision;
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Paint");
            e.Graphics.FillEllipse(Brushes.Blue, x, y, width, height);
        }

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("click x: " + e.Location.X);
            Console.WriteLine("click y: " + e.Location.Y);
            clickStack.Push(e.Location);
            //click opslaan en in de loop uitlezen
        }
    }
}
