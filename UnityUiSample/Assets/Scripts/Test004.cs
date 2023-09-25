using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test004 : MonoBehaviour
{
    public Slider slider;

    public Text txt;

    public Button btn_Start;
    public Button btn_Reset;

    private void Start()
    {
        slider.onValueChanged.AddListener(OnValueChanged_S);
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
    }

    void OnValueChanged_S(float f)
    {
        txt.text = $"{f}";
    }
    void OnClickStart()
    {
        txt.text = $"현재 진행된 값은 {slider.value} 입니다.";
    }
    void OnClickReset()
    {
        txt.text = string.Empty;
        slider.value = 0;
    }
}
