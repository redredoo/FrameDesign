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
        /// �¼�ע�� 
        /// </summary>
        /// <param name="onEvent"></param>
        public static void Register(Action onEvent)
        {
            mOnEvent += onEvent;
        }

        /// <summary>
        /// ȡ��ע��
        /// </summary>
        /// <param name="onEvent"></param>
        public static void UnRegister(Action onEvent)
        {
            mOnEvent -= onEvent;
        }

        /// <summary>
        /// �����¼�
        /// </summary>
        public static void Trigger()
        {
            mOnEvent?.Invoke();
        }
    }
}
