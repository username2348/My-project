﻿using UnityEngine;

namespace Ilumisoft.SkillDrive.DialogueSystem
{
    public class DialogueText : MonoBehaviour
    {
        [SerializeField, TextArea(3, 10)]
        string text = string.Empty;

        public string Text { get => this.text; set => this.text = value; }
    }
}