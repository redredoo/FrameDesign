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
                //�����¼��������Ѿ�ע����¼�����Ӧ�������ᱻִ��
                GameStartEvent.Trigger();
            });
        }

        void Update()
        {

        }
    }

}

