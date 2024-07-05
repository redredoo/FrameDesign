using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FrameDesign.Example
{
    public class UI : MonoBehaviour
    {
        private void Awake()
        {
            GamePassEvent.Register(OnGamePass);
        }

        private void OnGamePass()
        {
            transform.Find("Canvas/GameOverPanel").gameObject.SetActive(true);
        }

        private void OnDestroy()
        {
            GamePassEvent.UnRegister(OnGamePass);
        }
    }
}
