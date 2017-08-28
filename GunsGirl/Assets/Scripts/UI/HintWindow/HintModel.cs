using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HintResult();
public class HintModel{

    /// <summary>
    /// 提示信息
    /// </summary>
    private string hintInfo;
    public string HintInfo {get { return hintInfo; }} 

    /// <summary>
    /// 提示后的行为
    /// 再完成提示之后，做的动作
    /// </summary>
    private HintResult result;
    public HintResult Result { get { return result; } }

    public HintModel(string hintInfo, HintResult result)
    {
        this.result = result;
        this.hintInfo = hintInfo;
    }
    
}
