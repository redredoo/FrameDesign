using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FrameDesign.Example
{
    public class GameStartPanel : MonoBehaviour
    {

        void Start()
        {
            transform.Find("BtnStart").GetComponent<Button>().onClick.AddListener(() =>
            {
                gameObject.SetActive(false);
                //触发事件，所有已经注册该事件的响应方法都会被执行
                GameStartEvent.Trigger();
            });
        }

        void Update()
        {

        }
    }

}

