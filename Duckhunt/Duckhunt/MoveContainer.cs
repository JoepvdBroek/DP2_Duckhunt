using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt
{
    class MoveContainer : Container
    {
        List<MoveBehaviour> behaviourList = new List<MoveBehaviour>();

        public void Add(MoveBehaviour _moveBehaviour)
        {
            behaviourList.Add(_moveBehaviour);
        }

        public void Remove(MoveBehaviour _moveBehaviour)
        {
            if (behaviourList.Contains(_moveBehaviour))
            {
                behaviourList.Remove(_moveBehaviour);
            }
        }

        public void UpdateUnits()
        {
            foreach(MoveBehaviour mb in behaviourList)
            {
                mb.Update();
            }
        }
    }
}
