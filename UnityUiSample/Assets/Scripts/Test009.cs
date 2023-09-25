using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test009 : MonoBehaviour
{
    public Dropdown m_dd;

    public Text m_txt;

    public Button btn_Start;
    public Button btn_Reset;


    List<string> m_list = new List<string>();

    
    private void Start()
    {
        Dropdown.OptionData optionDataA = new Dropdown.OptionData();
        Dropdown.OptionData optionDataB = new Dropdown.OptionData();
        Dropdown.OptionData optionDataC = new Dropdown.OptionData();
        optionDataA.text = "���";
        m_dd.options.Add(optionDataA);
        optionDataB.text = "����";
        m_dd.options.Add(optionDataB);
        optionDataC.text = "����";
        m_dd.options.Add(optionDataC);

        m_dd.onValueChanged.AddListener(OnValueChangedDD);
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
    }

    void OnValueChangedDD(int list)
    {
        m_txt.text = $"{list} :{m_dd.options[list].text}";
    }
    void OnClickStart()
    {
        m_txt.text = $"����� �̵��� ���ô�{m_dd.options[m_dd.value].text}�Դϴ�.";
    }
    void OnClickReset()
    {
        m_dd.value = 0;
        m_txt.text = string.Empty;
    }
}
