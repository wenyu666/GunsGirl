using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintController:MonoBehaviour {

    public HintWindow hintWindow;
    private HintController() { }

    public void AddHints(HintModel hint)
    {
        hintWindow.Active(hint.HintInfo);
        hint.Result();
    }

}
