﻿using UnityEngine;

namespace Ilumisoft.SkillDrive.Effects
{
    [RequireComponent(typeof(TrailRenderer))]
    public class VehicleTrail : VehicleComponent
    {
        TrailRenderer trailRenderer;

        private void Awake()
        {
            trailRenderer = GetComponent<TrailRenderer>();
        }

        void Update()
        {
            if (Vehicle.IsGrounded != trailRenderer.emitting)
            {
                trailRenderer.emitting = Vehicle.IsGrounded;
            }
        }
    }
}