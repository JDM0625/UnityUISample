using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test003 : MonoBehaviour
{
    public Toggle toggle_A;
    public Toggle toggle_P;
    public Toggle toggle_O;

    public Text txt;

    public Button btn_Start;
    public Button btn_Reset;

    private void Start()
    {
        toggle_A.onValueChanged.AddListener(OnValueChanged_A);
        toggle_P.onValueChanged.AddListener(OnValueChanged_P);
        toggle_O.onValueChanged.AddListener(OnValueChanged_O);
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
    }

    private void OnValueChanged_A(bool isOn)
    {
        if (isOn)
        {
            txt.text = "사과";
        }
    }
    void OnValueChanged_P(bool isOn)
    {
        if (isOn)
        {
            txt.text = "배";
        }
    }
    void OnValueChanged_O(bool isOn)
    {
        if (isOn)
        {
            txt.text = "오린지";
        }
    }

    void OnClickStart()
    {
        txt.text = "당신이 선택한 과일은 ";
        if(toggle_A.isOn)
        {
            txt.text += "사과 ";
        }
        if (toggle_P.isOn)
        {
            txt.text += "배 ";
        }
        if (toggle_O.isOn)
        {
            txt.text += "오렌지 ";
        }
        if(toggle_A.isOn == false && toggle_O.isOn == false && toggle_P.isOn == false)
        {
            txt.text = "과일 선택 안하셨네요 ㅋㅋ";
            return;
        }
        txt.text += "입니다";
    }
    void OnClickReset()
    {
        txt.text = string.Empty;
        toggle_P.isOn = false;
        toggle_A.isOn = false;
        toggle_O.isOn = false;
    }

    
}
