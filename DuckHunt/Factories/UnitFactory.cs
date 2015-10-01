using DuckHunt.Containers;
using DuckHunt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunt.Factories
{
    class UnitFactory
    {
        private static UnitFactory instance;

        private UnitFactory() { }

        public static UnitFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnitFactory();
                }
                return instance;
            }
        }

        public Unit CreateUnit(string name, MoveContainer mc, DrawContainer dc, BehaviourFactory bf, MainWindow window)
        {
            switch (name)
            {
                case "Duck":
                    return new Duck(mc, dc, bf, window);
                case "Crow":
                    return new Crow(mc, dc, bf, window);
                default:
                    return new Duck(mc, dc, bf, window);
            }
        }
    }
}
