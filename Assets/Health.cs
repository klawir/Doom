using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    namespace GUI
    {
        public class Health : MonoBehaviour
        {
            public TextMesh textMesh;

            public void Setup(int health)
            {
                textMesh.text = health.ToString();
            }
        }
    }
}