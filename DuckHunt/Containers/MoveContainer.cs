using DuckHunt.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunt.Containers
{
    class MoveContainer : Container
    {
        public void Add(MoveBehaviour _moveBehaviour)
        {
            behaviours.Add(_moveBehaviour);
        }

        public void Remove(MoveBehaviour _moveBehaviour)
        {
            if (behaviours.Contains(_moveBehaviour))
            {
                behaviours.Remove(_moveBehaviour);
            }
        }

        public void MoveUnits(float deltaTime)
        {
            foreach (Behaviour behavior in behaviours)
            {
                behavior.Behave(deltaTime);
            }
        }
    }
}
