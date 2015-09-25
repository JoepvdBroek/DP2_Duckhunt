using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt
{
    class DrawBehaviour
    {
        private Unit unit;

        public DrawBehaviour(Unit unit)
        {
            this.unit = unit;
        }

        public void Update(Graphics g)
        {
            if (g != null)
            {
                g.DrawEllipse(Pens.Blue, unit.X, unit.Y, 30F, 30F);
            }
            
        }
    }
}
