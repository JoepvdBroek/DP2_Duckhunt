using System;

namespace Duckhunt
{
    internal class MoveBehaviour
    {
        private Unit unit;

        public MoveBehaviour(Unit unit)
        {
            this.unit = unit;
        }

        public void Update()
        {
            unit.X = unit.X + (1 * unit.Direction);
            //unit.Y = unit.Y + (1 * unit.Heading);
        }
    }
}