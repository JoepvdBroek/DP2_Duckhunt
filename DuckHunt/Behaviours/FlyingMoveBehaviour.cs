using DuckHunt.Models;

namespace DuckHunt.Behaviours
{
    class FlyingMoveBehaviour : MoveBehaviour
    {
        private Unit unit;

        public FlyingMoveBehaviour(Unit unit)
        {
            this.unit = unit;
        }

        public void Behave(float deltaTime)
        {
            if (unit.gotShot == 1)
            {
                GameController.score += 10;
            }
            unit.x += (0.20F * deltaTime) * unit.velocity;
            if (unit.x > 750)
            {
                GameController.score -= 100;
                unit.x = -unit.size;
            }

        }
    }
}
