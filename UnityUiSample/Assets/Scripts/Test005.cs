using UnityEngine;
using UnityEngine.UI;

public class Test005 : MonoBehaviour
{
    public Slider slider_R;
    public Slider slider_G;
    public Slider slider_B;

    public Text txt_R;
    public Text txt_G;
    public Text txt_B;

    public Text txt_Result;

    public Button btn_Start;
    public Button btn_Reset;

    private void Start()
    {
        slider_R.onValueChanged.AddListener(OnValueChanged_R);
        slider_G.onValueChanged.AddListener(OnValueChanged_G);
        slider_B.onValueChanged.AddListener(OnValueChanged_B);
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);

    }

    void OnValueChanged_R(float value)
    {
        txt_R.text = value.ToString();
        ColorChange();
    }
    void OnValueChanged_G(float value)
    {
        txt_G.text = value.ToString();
        ColorChange();
    }
    void OnValueChanged_B(float value)
    {
        txt_B.text = value.ToString();
        ColorChange();
    }

    void ColorChange()
    {
        byte R = (byte)slider_R.value;
        byte G = (byte)slider_G.value;
        byte B = (byte)slider_B.value;
        txt_Result.color = new Color32(R, G, B, 255);
    }

    void OnClickStart()
    {
        txt_Result.text = $"당신이 선택한 색{slider_R.value}, {slider_G.value}, {slider_B.value}";
    }
    void OnClickReset()
    {
        slider_R.value = 0;
        slider_G.value = 0;
        slider_B.value = 0;
        txt_Result.text = string.Empty;
    }
}
