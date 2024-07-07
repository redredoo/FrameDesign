using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameDesign
{
    public class Event<T> where T : Event<T>
    {
        private static Action mOnEvent;
        /// <summary>
        /// 事件注册 
        /// </summary>
        /// <param name="onEvent"></param>
        public static void Register(Action onEvent)
        {
            mOnEvent += onEvent;
        }

        /// <summary>
        /// 取消注册
        /// </summary>
        /// <param name="onEvent"></param>
        public static void UnRegister(Action onEvent)
        {
            mOnEvent -= onEvent;
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        public static void Trigger()
        {
            mOnEvent?.Invoke();
        }
    }
}
