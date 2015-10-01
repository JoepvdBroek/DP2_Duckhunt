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
                Console.WriteLine("2: draw unit : x = " + unit.X + " y = " + unit.Y);
                g.FillEllipse(Brushes.Blue, unit.X, unit.Y, 30F, 30F);
                //margin = new Thickness();
            }
            
        }
    }
}
