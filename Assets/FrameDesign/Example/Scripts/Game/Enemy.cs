using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameDesign.Example
{
    public class Enemy : MonoBehaviour
    {
        public GameObject GameOverObj;

        private void OnMouseDown()
        {
            Destroy(gameObject);
        }
    }
}

