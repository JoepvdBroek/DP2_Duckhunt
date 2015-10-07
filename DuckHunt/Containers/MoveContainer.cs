using DuckHunt.Behaviours;

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
            for (int i = 0; i < behaviours.Count; i++)
            {
                behaviours[i].Behave(deltaTime);
            }

            //foreach (Behaviour behavior in behaviours)
            //{
            //    behavior.Behave(deltaTime);
            //}
        }
    }
}
