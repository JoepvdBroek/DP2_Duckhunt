using DuckHunt.Behaviours;
using DuckHunt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunt.Factories
{
    class BehaviourFactory
    {
        private static BehaviourFactory instance;

        private BehaviourFactory() { }

        public static BehaviourFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BehaviourFactory();
                }
                return instance;
            }
        }

        internal MoveBehaviour CreateMoveBehaviour(Unit unit)
        {
            return new MoveBehaviour(unit);
        }
        internal DrawBehaviour CreateDrawBehaviour(Unit unit)
        {
            return new DrawBehaviour(unit);
        }

    }
}
