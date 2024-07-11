using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CounterApp
{
    public class ViewCtrl : MonoBehaviour
    {

        private void Start()
        {
            Model.OnCountChanged += UpdateView;

            //主动调用一次
            UpdateView(Model.Count);

            transform.Find("BtnAdd").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                Model.Count++;
            });

            transform.Find("BtnSub").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                Model.Count--;
            });

        }

        private void OnDestroy()
        {
            Model.OnCountChanged -= UpdateView;
        }

        private void UpdateView(int newCount)
        {
            transform.Find("ViewNum").GetComponent<Text>().text = newCount.ToString();
        }
    }
}
