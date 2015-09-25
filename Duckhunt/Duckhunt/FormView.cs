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
        private Stack<Point> clickStack;
        private Random rnd = new Random();
        private GameController gameController;
        private Graphics graphics;

        public Graphics Graphics { get; set; }

        public FormView()
        {
            InitializeComponent();

            Graphics = CreateGraphics();
            //Graphics.DrawEllipse(Brushes.Blue, 50, 50, 30, 30);

            clickStack = new Stack<Point>();

            gameController = new GameController(this);
        }

        public void UpdateView()
        {
            //MoveUnit();

            /*if (clickStack.Count > 0)
            {
                if (CheckClickCollision(clickStack.Pop()))
                {
                    Console.WriteLine("COLLISION !!!!");
                    x = rnd.Next(1, (this.Size.Width - width * 2));
                    y = rnd.Next(1, (this.Size.Height - height * 2));
                    //remove moving object
                }
            }*/

            Invalidate();
            
        }


        /*private bool CheckClickCollision(Point location)
        {
            bool collision = false;

            if ((location.X > x) && (location.X < (x + 30)) && (location.Y > y) && (location.Y < (y + 30)))
            {
                collision = true;
            }

            return collision;
        }*/

        private void Form_Paint(object sender, PaintEventArgs e)
         {
            //Console.WriteLine("fill graphics variable");
          
            //Graphics = e.Graphics;
            //graphics.FillEllipse(Brushes.Blue, x, y, width, height);
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
