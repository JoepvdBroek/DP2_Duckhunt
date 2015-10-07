using DuckHunt.Containers;
using DuckHunt.Models;
using System;
using System.Collections.Generic;

namespace DuckHunt.Factories
{
    class UnitFactory
    {
        private static UnitFactory instance;
        private Dictionary<string, Unit> unitMap = new Dictionary<string, Unit>();

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

        public void addUnitToMap(String name, Unit unit)
        {
            unitMap.Add(name, unit);
        }

        public Unit CreateUnit(string name, MoveContainer mc, DrawContainer dc, BehaviourFactory bf, MainWindow window)
        {
            if (unitMap.ContainsKey(name))
            {
                return unitMap[name].CreateInstance(mc, dc, bf, window);
            }

            throw new Exception("Unit with the name "+ name +" Not Found");
        }
    }
}
