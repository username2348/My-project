using UnityEngine;

namespace Ilumisoft.SkillDrive.DialogueSystem
{
    public class DialogueText : MonoBehaviour
    {
        public MultiText text;
        
        public string Text
        {
            get => text.GetText();
        }
    }
}