using DuckHunt.Models;

namespace DuckHunt.Behaviours
{
    interface MoveBehaviour : Behaviour
    {
        MoveBehaviour CreateInstance(Unit unit);
    }
}
