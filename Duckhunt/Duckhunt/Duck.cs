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
        private DrawContainer _drawContainer;
        private DrawBehaviour _drawBehaviour;

        public Duck(MoveContainer mc, DrawContainer dc, BehaviourFactory bf)
        {
            _moveContainer = mc;
            _drawContainer = dc;
            _moveBehaviour = bf.CreateMoveBehaviour(this);
            _drawBehaviour = bf.CreateDrawBehaviour(this);
            _moveContainer.Add(_moveBehaviour);
            _drawContainer.Add(_drawBehaviour);

            X = 50.0F;
            Y = 50.0F;
            Direction = 1;
            Heading = 1.5F;
        }

        private void Die()
        {
            _moveContainer.Remove(_moveBehaviour);
        }

    }
}
