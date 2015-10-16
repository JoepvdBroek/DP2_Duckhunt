using System;
using DuckHunt.Models;
using DuckHunt.Factories;

namespace DuckHunt.Behaviours
{
    class FallingMoveBehaviour : MoveBehaviour
    {
        private Unit unit;

        public FallingMoveBehaviour(Unit unit)
        {
            this.unit = unit;
        }

        public FallingMoveBehaviour() { }

        public void Behave(float deltaTime)
        {
            if (unit.gotShot == 2)
            {
                GameController.score += 30;
                unit.y = Unit.rnd.Next(27, 300);
                unit.x = -unit.size;
                unit.changeMoveBehaviour("flying");
                unit.gotShot = 0;
            } else
            {
                unit.x += (0.15F * deltaTime) * unit.velocity;
                unit.y += (0.15F * deltaTime) * unit.velocity / 2;
            }

            if (unit.x > 750)
            {
                GameController.score -= 50;
                unit.y = Unit.rnd.Next(27, 300);
                unit.x = -unit.size;
                unit.changeMoveBehaviour("flying");
                unit.gotShot = 0;
            }

            if (unit.y > 425)
            {
                unit.y = Unit.rnd.Next(27, 300);
                unit.x = -unit.size;
                unit.changeMoveBehaviour("flying");
                unit.gotShot = 0;
            }

        }

        public static void AddBehaviourToFactory()
        {
            BehaviourFactory.Instance.addMoveBehaviourToMap("falling", new FallingMoveBehaviour());
        }

        public MoveBehaviour CreateInstance(Unit unit)
        {
            return new FallingMoveBehaviour(unit);
        }
    }
}
