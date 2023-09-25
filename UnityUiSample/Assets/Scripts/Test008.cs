using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test008 : MonoBehaviour
{
    public Dropdown m_dDown;

    public Text m_txt;

    public Button m_btn_Start;
    public Button m_btn_Reset;


    private void Start()
    {
        m_dDown.onValueChanged.AddListener(OnValueChangedDD);
        m_btn_Start.onClick.AddListener(OnClickStart);
        m_btn_Reset.onClick.AddListener(OnClickReset);
    }

    void OnValueChangedDD(int value)
    {
        m_txt.text = $"{value+1}: {m_dDown.options[value].text}";
    }

    void OnClickStart()
    {
        m_txt.text = $"당신이 이동할 도시는 <color=#0080000>{m_dDown.options[m_dDown.value].text}</color>입니다.";
    }
    void OnClickReset()
    {
        m_txt.text = string.Empty;
        m_dDown.value = 0;
    }
}
