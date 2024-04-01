using DefaultNamespace;
using UnityEngine;
using UnityEngine.Events;
using YG;

namespace Ilumisoft.SkillDrive.DialogueSystem
{
    public class OnDialogueComplete : MonoBehaviour
    {
        [SerializeField]
        Dialogue dialogue;

        public UnityEvent actions = new UnityEvent();

        private void Reset()
        {
            dialogue = GetComponentInParent<Dialogue>();
        }

        private void OnEnable()
        {
            if (dialogue != null)
            {
                dialogue.OnComplete += OnComplete;
            }
        }

        private void OnDisable()
        {
            if (dialogue != null)
            {
                dialogue.OnComplete -= OnComplete;
            }
        }

        private void OnComplete()
        {
            YandexControl.Instance.SwicthMobileInputsState(YandexGame.EnvironmentData.isMobile);
            actions?.Invoke();
        }
    }
}