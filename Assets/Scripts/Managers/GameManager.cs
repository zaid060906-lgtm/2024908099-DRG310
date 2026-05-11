using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment2.Data;
using Assignment2.Systems;
using System.Collections.Generic;

namespace Assignment2.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [Header("Settings")]
        public GameObject enemyPrefab; // اسحب الـ Prefab هنا من الـ Inspector
        public int enemyCount = 100;

        [Header("Data")]
        public PlayerData playerData;
        public Transform playerTransform; // اسحب كائن اللاعب هنا

        private MovementSystem _moveSystem;
        private EnemySystem _enemySystem;
        private List<GameObject> _enemyVisuals = new List<GameObject>(); // قائمة للأشكال فقط

        void Awake()
        {
            Instance = this;
            _moveSystem = new MovementSystem();
            _enemySystem = new EnemySystem();
            
            playerData = new PlayerData(5f, 100);
            _enemySystem.Initialize(enemyCount);

            // إنشاء الأشكال البصرية للـ 100 عدو مرة واحدة (Object Pooling)
            for (int i = 0; i < enemyCount; i++)
            {
                GameObject e = Instantiate(enemyPrefab);
                _enemyVisuals.Add(e);
            }
        }

        void Update()
        {
            float dt = Time.deltaTime;
            Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            // 1. تحديث المنطق (Logic) - سريع جداً لأنه يغير أرقام فقط
            _moveSystem.Update(ref playerData, dt, input);
            _enemySystem.UpdateEnemies(dt);

            // 2. تحديث الأشكال (Visuals) - ربط الشكل بالبيانات
            playerTransform.position = playerData.Position;

            for (int i = 0; i < enemyCount; i++)
            {
                _enemyVisuals[i].transform.position = _enemySystem.Enemies[i].Position;
            }
        }
    }
}