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

        public void Behave(float deltaTime)
        {
            //unit.x++;
            unit.x += (0.20F * deltaTime) * unit.velocity;
            if (unit.x > 750)
            {
                unit.x = -unit.size;
            }

        }
    }
}
