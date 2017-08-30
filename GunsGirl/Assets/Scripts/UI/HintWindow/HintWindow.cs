using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintWindow : MonoBehaviour {

    public Button closeButton;
    public Text hintInfo;

    public void Active(HintModel hint)
    {
        gameObject.SetActive(true);
        hintInfo.text = hint.HintInfo;
        hint.Result();
    }

    /// <summary>
    /// 关闭按钮触发事件
    /// </summary>
    public void CloseButtonMethod()
    {
        gameObject.SetActive(true);
    }

}
