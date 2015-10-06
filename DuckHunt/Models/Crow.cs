using DuckHunt.Behaviours;
using DuckHunt.Containers;
using DuckHunt.Factories;
using System;
using System.Windows.Media;
using System.Windows.Threading;

namespace DuckHunt.Models
{
    class Crow : Unit
    {

        public Crow(MoveContainer mc, DrawContainer dc, BehaviourFactory bf, MainWindow window) : base(mc, dc, bf, window)
        {
            //rnd = new Random();
            size = 40;
            x = 0;
            y = rnd.Next(26, 300);
            color = Brushes.Black;
            velocity = 1.0F;

            this.window = window;
            dispatcher = Dispatcher.CurrentDispatcher;

            InitUnit();
        }
    }
}
