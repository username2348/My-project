using Ilumisoft.SkillDrive.Game;
using UnityEngine;

namespace Ilumisoft.SkillDrive.UI
{
    public class LevelNumberDisplay : MonoBehaviour
    {
        [SerializeField]
        LevelData levelData = null;

        [SerializeField]
        TMPro.TextMeshProUGUI text = null;

        private readonly MultiText _levelText = new MultiText("Уровень", "Level");


        void Start()
        {
            int levelNumber = levelData.GetLevelNumber(gameObject.scene);

            text.text = $"{_levelText.GetText()} {levelNumber}";
        }
    }
}