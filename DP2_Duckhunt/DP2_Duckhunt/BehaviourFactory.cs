using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2_Duckhunt
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

        internal MoveBehaviour CreateMoveBehaviour(Duck duck)
        {
            throw new NotImplementedException();
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
