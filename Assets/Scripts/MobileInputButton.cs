using System;
using Ilumisoft.SkillDrive.Input;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class MobileInputButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public Vector2 activeVector;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            VehiclePlayerInput.mobileVector += activeVector;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
           if(VehiclePlayerInput.mobileVector.x != activeVector.x && 
              VehiclePlayerInput.mobileVector.y != activeVector.y) return;
           VehiclePlayerInput.mobileVector -= activeVector;
        }
    }
}