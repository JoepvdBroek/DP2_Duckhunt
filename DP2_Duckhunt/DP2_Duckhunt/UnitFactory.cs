using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2_Duckhunt
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

        public Unit Create(string name)
        {
            if (name.Equals("Duck"))
            {
                //return new Duck();
            }

            return null;

        }
    }
}
