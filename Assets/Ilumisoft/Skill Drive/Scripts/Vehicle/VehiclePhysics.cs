﻿using UnityEngine;

namespace Ilumisoft.SkillDrive
{
    /// <summary>
    /// Data class containing the physics data of the vehicle, like the amount of gravity that should be applied to it.
    /// </summary>
    [System.Serializable]
    public class VehiclePhysics
    {
        [Tooltip("The gravity applied when the vehicle is grounded")]
        [SerializeField]
        float gravity = 20;

        [Tooltip("The gravity applied when the vehicle is flying")]
        [SerializeField]
        float fallGravity = 50;

        public float Gravity { get => this.gravity; set => this.gravity = value; }

        public float FallGravity { get => this.fallGravity; set => this.fallGravity = value; }
    }
}
