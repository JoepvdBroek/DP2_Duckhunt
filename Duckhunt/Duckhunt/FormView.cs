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

        int x = 100;
        int y = 100;
        public FormView()
        {
            InitializeComponent();

            //Graphics = CreateGraphics();
            graphics = canvas.CreateGraphics();

            clickStack = new Stack<Point>();

            gameController = new GameController(this, graphics);
        }

        public void UpdateView()
        {
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

            x++;

            Console.WriteLine("3: update view");
            canvas.Invalidate();
            //canvas.Update();
            
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

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("click x: " + e.Location.X);
            Console.WriteLine("click y: " + e.Location.Y);
            clickStack.Push(e.Location);
            //click opslaan en in de loop uitlezen
        }

        private void FormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameController.StopLoop();
        }
    }
}
