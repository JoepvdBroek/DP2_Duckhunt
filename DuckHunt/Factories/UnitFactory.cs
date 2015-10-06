using DuckHunt.Containers;
using DuckHunt.Models;
using System;
using System.Collections.Generic;

namespace DuckHunt.Factories
{
    class UnitFactory
    {
        private static UnitFactory instance;
        private Dictionary<string, Unit> units;

        private UnitFactory()
        {
            units = new Dictionary<string, Unit>();
            units.Add("Duck", new Duck());
            units.Add("Crow", new Crow());
        }

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
            if (units.ContainsKey(name))
            {
                return units[name].CreateInstance(mc, dc, bf, window);
            }

            throw new Exception("Unit with the name "+ name +" Not Found");
        }
    }
}
