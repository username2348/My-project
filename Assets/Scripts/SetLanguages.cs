using UnityEngine;
using YG;

namespace DefaultNamespace
{
    public class SetLanguages : MonoBehaviour
    {
        private void Awake()
        {
            YandexGame.InitLang();
            MultiTextUI.lang = YandexGame.lang;
        }
    }
}