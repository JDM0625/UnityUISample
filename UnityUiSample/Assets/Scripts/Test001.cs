using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test001 : MonoBehaviour
{
    public InputField m_inputftxt;
    public Text txt;

    public Button btn_Ok;
    public Button btn_Clear;
    // Start is called before the first frame update
    void Start()
    {
        m_inputftxt.onSubmit.AddListener(OnSubmit);
        btn_Ok.onClick.AddListener(OnClickOK);
        btn_Clear.onClick.AddListener(OnClickClear);
    }

    void OnSubmit(string str)
    {
        txt.text += $"당신이 입력한 이름은{m_inputftxt.text} 입니다.";
    }
    void OnClickOK()
    {
        txt.text += $"당신이 입력한 이름은{m_inputftxt.text} 입니다.";
    }
    void OnClickClear()
    {
        txt.text = string.Empty;
        m_inputftxt.text = string.Empty;
    }
}
