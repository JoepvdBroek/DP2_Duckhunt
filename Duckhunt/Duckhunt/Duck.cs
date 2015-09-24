using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt
{
    class Duck : Unit
    {
        private MoveContainer _moveContainer;
        private MoveBehaviour _moveBehaviour;

        public Duck(MoveContainer mc, BehaviourFactory bf)
        {
            _moveContainer = mc;
            _moveBehaviour = bf.CreateMoveBehaviour(this);
            _moveContainer.Add(_moveBehaviour);
        }

        private void Die()
        {
            _moveContainer.Remove(_moveBehaviour);
        }

    }
}
