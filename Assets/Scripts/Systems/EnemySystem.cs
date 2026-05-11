using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment2.Data;

namespace Assignment2.Systems
{
    public class EnemySystem
    {
        public EnemyData[] Enemies;

        public void Initialize(int count)
        {
            Enemies = new EnemyData[count];
            for (int i = 0; i < count; i++)
            {
                // توزيع الأعداء في أماكن عشوائية فوق الشاشة
                Enemies[i].Position = new Vector2(Random.Range(-8f, 8f), Random.Range(5f, 15f));
                Enemies[i].Speed = Random.Range(2f, 4f);
                Enemies[i].IsActive = true;
            }
        }

        public void UpdateEnemies(float deltaTime)
        {
            for (int i = 0; i < Enemies.Length; i++)
            {
                if (Enemies[i].IsActive)
                {
                    // تحريك العدو للأسفل
                    Enemies[i].Position += Vector2.down * Enemies[i].Speed * deltaTime;

                    // إذا خرج العدو من الشاشة، يعود للأعلى (Loop)
                    if (Enemies[i].Position.y < -5f)
                    {
                        Enemies[i].Position.y = 10f;
                        // هنا نرسل حدث زيادة النقاط (Point System)
                        Assignment2.Events.EventManager.TriggerScoreChanged(10);
                    }
                }
            }
        }
    }
}