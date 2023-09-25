using UnityEngine;
using UnityEngine.UI;

public class Tset006 : MonoBehaviour
{
    public Scrollbar scrolb;

    public Button btn_Start;
    public Button btn_Reset;

    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        scrolb.onValueChanged.AddListener(OnValueChangedS);
        btn_Start.onClick.AddListener(OnClickStart);
        btn_Reset.onClick.AddListener(OnClickReset);
    }

    void OnValueChangedS(float value)
    {
        txt.text = $"{value:0.00}";
    }

    void OnClickStart()
    {
        txt.text = $"현재 진행된 값은 {scrolb.value:0.00} 입니다.";
    }
    void OnClickReset()
    {
        scrolb.value = 0;
        txt.text = string.Empty;
    }

}
