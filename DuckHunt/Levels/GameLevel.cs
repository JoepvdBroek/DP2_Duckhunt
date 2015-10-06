using DuckHunt.Controllers;

namespace DuckHunt.Levels
{
    internal interface GameLevel
    {
        BaseLevelState CreateInstance();
    }
}