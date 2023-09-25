using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test007 : MonoBehaviour
{
    public Scrollbar m_bar;

    public Text m_txt;

    public Button m_btn_Start;
    public Button m_btn_Reset;

    float time;

    bool isStart = false;

    private void Start()
    {
        m_bar.onValueChanged.AddListener(OnValueChangedBar);
        m_btn_Start.onClick.AddListener(OnClickStart);
        m_btn_Reset.onClick.AddListener(OnClickReset);
    }

    void OnValueChangedBar(float value)
    {
        ChangeColor(value);
        ResultTxt(value);
    }
    void OnClickStart()
    {
        isStart = true;
    }
    void OnClickReset()
    {
        m_txt.text = string.Empty;
        m_bar.value = 0;
    }

    private void Update()
    {
        if(isStart == true)
        {
            ChangeValue();
        }
    }

    void ChangeValue()
    {
        if (m_bar.value >= 1)
        {
            m_bar.value = 1;
            isStart = false;
        }
        time += Time.deltaTime;
        if(time >= 0.5)
        {
            m_bar.value += 0.05f;
            time = 0;
        }
        
    }

    void ChangeColor(float value)
    {
        m_txt.color = new Color(m_txt.color.r, m_txt.color.g, m_txt.color.b, value);
    }

    void ResultTxt(float value)
    {
        m_txt.text = $"{value:0.00}";
    }
}
