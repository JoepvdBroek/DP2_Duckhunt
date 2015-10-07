using DuckHunt.Containers;
using DuckHunt.Factories;
using System.Windows.Media;
using System.Windows.Threading;
using System;

namespace DuckHunt.Models
{
    class Crow : Unit
    {
        public Crow() { }

        public Crow(MoveContainer mc, DrawContainer dc, BehaviourFactory bf, MainWindow window) : base(mc, dc, bf, window)
        {
            //rnd = new Random();
            size = 40;
            x = 0;
            y = rnd.Next(26, 300);
            color = Brushes.Black;
            velocity = 1.0F;
            heading = 1.5F;

            this.window = window;
            dispatcher = Dispatcher.CurrentDispatcher;

            InitUnit();
        }

        public static void AddUnitToFactory()
        {
            UnitFactory.Instance.addUnitToMap("Crow", new Crow());
        }

        public override Unit CreateInstance(MoveContainer mc, DrawContainer dc, BehaviourFactory bf, MainWindow window)
        {
            return new Crow(mc, dc, bf, window);
        }
    }
}
