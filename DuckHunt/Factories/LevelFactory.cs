using DuckHunt.Controllers;
using System.Collections.Generic;

namespace DuckHunt.Factories
{
    class LevelFactory
    {
        private static LevelFactory instance;
        private Dictionary<int, BaseLevelState> levelMap = new Dictionary<int, BaseLevelState>();

        private LevelFactory() {}

        public static LevelFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LevelFactory();
                }
                return instance;
            }
        }

        public void addLevelToMap(BaseLevelState level)
        {
            levelMap.Add(level.id, level);
        }

        public BaseLevelState NextLevel(BaseLevelState currentLevel)
        {
            if (currentLevel == null) return null;

            //last level
            if(levelMap.Count == currentLevel.id)
            {
                return null;
            }
            else
            {
                return levelMap[currentLevel.id + 1]/*.CreateInstance()*/;
            }

        }
    }
}
