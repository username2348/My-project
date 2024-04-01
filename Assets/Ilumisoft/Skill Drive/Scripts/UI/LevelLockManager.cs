using UnityEngine;
using YG;

namespace Ilumisoft.SkillDrive
{
    public static class LevelLockManager
    {
        public static void UnlockLevel(int levelNumber)
        {
            YandexGame.savesData.unlockedLvls += $";UnlockedLevels/Level{levelNumber}";
            YandexGame.SaveProgress();
        }

        public static bool IsLocked(int levelNumber)
        {
            if (levelNumber == 1)
            {
                return false;
            }

            return !YandexGame.savesData.unlockedLvls.Contains($"UnlockedLevels/Level{levelNumber}");
        }
    }
}