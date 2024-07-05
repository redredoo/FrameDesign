using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FrameDesign.Example
{
    public class GamePassEvent
    {
        public static Action mOnEvent;

        public static void Register(Action onEvent)
        {
            mOnEvent += onEvent;
        }

        public static void UnRegister(Action onEvent)
        {
            mOnEvent -= onEvent;
        }

        public static void Trigger()
        {
            mOnEvent?.Invoke();
        }
    }
}
