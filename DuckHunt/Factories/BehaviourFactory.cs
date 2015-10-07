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
        private Dictionary<string, MoveBehaviour> moveBehaviourMap = new Dictionary<string, MoveBehaviour>();
        private Dictionary<string, DrawBehaviour> drawBehaviourMap = new Dictionary<string, DrawBehaviour>();

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

        internal MoveBehaviour CreateMoveBehaviour(Unit unit, string behaviour)
        {
            if (moveBehaviourMap.ContainsKey(behaviour))
            {
                return moveBehaviourMap[behaviour].CreateInstance(unit);
            }

            throw new Exception("Behaviour with the name " + behaviour + " Not Found");
        }

        internal DrawBehaviour CreateDrawBehaviour(Unit unit, string behaviour)
        {
            if (drawBehaviourMap.ContainsKey(behaviour))
            {
                return drawBehaviourMap[behaviour].CreateInstance(unit);
            }

            throw new Exception("Behaviour with the name " + behaviour + " Not Found");
        }

        internal void addDrawBehaviourToMap(string name, DrawBehaviour drawBehaviour)
        {
            drawBehaviourMap.Add(name, drawBehaviour);
        }

        internal void addMoveBehaviourToMap(string name, MoveBehaviour moveBehaviour)
        {
            moveBehaviourMap.Add(name, moveBehaviour);
        }
    }
}
