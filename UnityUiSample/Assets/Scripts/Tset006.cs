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
        txt.text = $"���� ����� ���� {scrolb.value:0.00} �Դϴ�.";
    }
    void OnClickReset()
    {
        scrolb.value = 0;
        txt.text = string.Empty;
    }

}
