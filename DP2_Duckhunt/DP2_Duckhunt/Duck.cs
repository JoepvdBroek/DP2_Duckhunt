using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2_Duckhunt
{
    class Duck
    {
        private MoveContainer moveContainer;
        private MoveBehaviour moveBehaviour;

        public Duck(MoveContainer mc, BehaviourFactory bf)
        {
            moveContainer = mc;
            moveBehaviour = bf.CreateMoveBehaviour(this);
            moveContainer.Add(moveBehaviour);
        }

        private void Die()
        {
            moveContainer.Remove(moveBehaviour);
        }
    }
}
