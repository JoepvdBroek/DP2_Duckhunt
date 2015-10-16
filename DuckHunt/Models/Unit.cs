using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using DuckHunt.Containers;
using DuckHunt.Factories;
using DuckHunt.Behaviours;

namespace DuckHunt.Models
{
    abstract class Unit
    {
        public int direction { get; set; }
        public int size { get; set; }
        public float heading { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public Brush color { get; set; }
        public float velocity { get; set; }
        public int gotShot { get; set; }
        public int score { get; set; }

        protected MainWindow window;
        public Rectangle rect;
        public Dispatcher dispatcher;
        public static Random rnd = new Random();
        private MoveContainer moveContainer;
        private DrawContainer drawContainer;
        private BehaviourFactory behaviourFactory;
        private DrawBehaviour drawBehaviour;
        private MoveBehaviour moveBehaviour;

        public Unit(MoveContainer mc, DrawContainer dc, BehaviourFactory bf, MainWindow window)
        {
            moveContainer = mc;
            drawContainer = dc;
            behaviourFactory = bf;
            this.window = window;
           
            moveBehaviour = behaviourFactory.CreateMoveBehaviour(this, "flying");
            drawBehaviour = behaviourFactory.CreateDrawBehaviour(this, "flying");
            moveContainer.Add(moveBehaviour);
            drawContainer.Add(drawBehaviour);

            this.window = window;
            dispatcher = Dispatcher.CurrentDispatcher;
        }

        public Unit() { }

        public abstract Unit CreateInstance(MoveContainer mc, DrawContainer dc, BehaviourFactory bf, MainWindow window);

        public void changeMoveBehaviour(string behaviour)
        {
            moveContainer.Remove(moveBehaviour);
            moveBehaviour = behaviourFactory.CreateMoveBehaviour(this, behaviour);
            moveContainer.Add(moveBehaviour);
        }

        public Rectangle InitUnit()
        {
            gotShot = 0;
            rect = new Rectangle
            {
                Fill = color,
                Width = size,
                Height = size,
                Cursor = Cursors.Hand
            };
            rect.MouseLeftButtonDown += getShot;
            RestartUnit();
            window.canvas.Children.Add(rect);
            return rect;
        }

        private void Die(object sender, MouseButtonEventArgs e)
        {
            window.canvas.Children.Remove(rect);
            moveContainer.Remove(moveBehaviour);
            drawContainer.Remove(drawBehaviour);
        }

        protected void RestartUnit()
        {
            x = -size;
            y = rnd.Next(26, 300);
            rect.Margin = new Thickness(x, y, size, size);
        }

        protected void getShot(object sender, RoutedEventArgs e)
        {
            gotShot++;
            if(gotShot == 1)
            {
                changeMoveBehaviour("falling");
            }
        }
    }
}
