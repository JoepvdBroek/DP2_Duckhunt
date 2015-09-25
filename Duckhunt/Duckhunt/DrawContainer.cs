using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt
{
    class DrawContainer : Container
    {
        List<DrawBehaviour> behaviourList = new List<DrawBehaviour>();

        public void Add(DrawBehaviour _drawBehaviour)
        {
            behaviourList.Add(_drawBehaviour);
        }

        public void Remove(DrawBehaviour _drawBehaviour)
        {
            if (behaviourList.Contains(_drawBehaviour))
            {
                behaviourList.Remove(_drawBehaviour);
            }
        }

        public void UpdateUnits(Graphics g)
        {
            foreach (DrawBehaviour db in behaviourList)
            {
                db.Update(g);
            }
        }
    }
}
