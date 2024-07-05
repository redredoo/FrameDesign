using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameDesign.Example
{
    public class Enemy : MonoBehaviour
    {
        public GameObject GameOverObj;

        static int mKilledEnemyCount = 0;

        private void OnMouseDown()
        {
            Destroy(gameObject);
            mKilledEnemyCount++;
            if (mKilledEnemyCount == 10)
            {
                GamePassEvent.Trigger();
            }
        }
    }
}

