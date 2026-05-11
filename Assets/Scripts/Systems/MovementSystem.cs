using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment2.Data;

namespace Assignment2.Systems
{
    // ملاحظة: لا تضع ": MonoBehaviour" هنا
    public class MovementSystem
    {
        public void Update(ref PlayerData player, float deltaTime, Vector2 input)
        {
            // معادلة الحركة الموجهة بالبيانات المطلوبة في الواجب
            player.Position += input * player.Speed * deltaTime;
        }
    }
}