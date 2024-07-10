using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameDesign.Example
{
    public class Game : MonoBehaviour
    {
        private void Awake()
        {
            //事件注册要考虑注销
            GameStartEvent.Register(OnGameStart);
            KilledOneEnemyEvent.Register(OnEnemyKilled);
        }

        private void OnEnemyKilled()
        {
            GameModel.KillCount++;
            if (GameModel.KillCount == 10)
            {
                GamePassEvent.Trigger();
            }
        }

        private void OnGameStart()
        {
            transform.Find("Enemies").gameObject.SetActive(true);
        }

        private void OnDestroy()
        {
            GameStartEvent.UnRegister(OnGameStart);
            KilledOneEnemyEvent.UnRegister(OnEnemyKilled);
        }
    } 
}
