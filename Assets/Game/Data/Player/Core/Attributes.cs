
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    namespace Core
    {
        public class Attributes : MonoBehaviour
        {
            public int health;
            public int speed;
            public GUI.Health guiHealth;

            private void Start()
            {
                guiHealth.Setup(health);
            }
        }
    }
}