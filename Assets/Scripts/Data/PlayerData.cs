using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment2.Data
{
    public struct PlayerData 
    {
        public Vector2 Position;
        public float Speed;
        public int Health;

        public PlayerData(float speed, int health)
        {
            Position = Vector2.zero;
            Speed = speed;
            Health = health;
        }
    }
}