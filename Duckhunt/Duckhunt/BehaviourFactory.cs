using System;

namespace Duckhunt
{
    public class BehaviourFactory
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
            return new MoveBehaviour(duck);
        }
        internal DrawBehaviour CreateDrawBehaviour(Duck duck)
        {
            return new DrawBehaviour(duck);
        }
    }
}