using DuckHunt.Models;

namespace DuckHunt.Behaviours
{
    class MoveBehaviour : Behaviour
    {
        private Unit unit;

        public MoveBehaviour(Unit unit)
        {
            this.unit = unit;
        }

        public void Behave()
        {
            unit.x++;
            if (unit.x > 750)
            {
                unit.x = -unit.size;
            }
        }
    }
}
