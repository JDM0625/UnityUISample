using UnityEngine;
using UnityEngine.UI;

public class Test002 : MonoBehaviour
{
    public Toggle toggle_Apple;
    public Toggle toggle_Pear;
    public Toggle toggle_Orange;

    public Text txt;

    public Button btn_Start;
    public Button btn_Reset;

    private void Start()
    {
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
        toggle_Apple.onValueChanged.AddListener(OnValueChanged_A);
        toggle_Pear.onValueChanged.AddListener(OnValueChanged_P);
        toggle_Orange.onValueChanged.AddListener(OnValueChanged_O);

    }

    void OnValueChanged_A(bool isOn)
    {
        if (isOn == true)
        {
            txt.text = "���";
        }
    }

    void OnValueChanged_P(bool isOn)
    {
        if (isOn == true)
        {
            txt.text = "��";
        }
    }
    void OnValueChanged_O(bool isOn)
    {
        if (isOn == true)
        {
            txt.text = "������";
        }
    }

    void OnClickStart()
    {
        txt.text = "����� ������ ������ ";
        if (toggle_Apple.isOn)
        {
            txt.text += "��� ";
        }
        if (toggle_Pear.isOn)
        {
            txt.text += "�� ";
        }
        if (toggle_Orange.isOn)
        {
            txt.text += "������ ";
        }

        if (toggle_Apple.isOn == false && toggle_Pear.isOn == false && toggle_Orange.isOn == false)
        {
            txt.text = "������ ������ �����ϴ� >:(";
            return;
        }
        txt.text += "�Դϴ�";
    }


    void OnClickReset()
    {
        txt.text = string.Empty;
        toggle_Apple.isOn = false;
        toggle_Orange.isOn = false;
        toggle_Pear.isOn = false;
    }
}
