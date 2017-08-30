using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 查找工具
/// </summary>
public class TransformHelper : MonoBehaviour {


    /// <summary>
    /// 查找根节点下的目标子物体
    /// </summary>
    /// <param name="root">根节点</param>
    /// <param name="targetName">想要寻找的子物体的名字</param>
    public static Transform FindChild(Transform root,string targetName)
    {
        //Transform currentNode = root;//当前节点

        if (root.transform.childCount<=0)
        {
            Debug.LogError("没有找到目标，请检查输入");
            return default(Transform);
        }
        if (root.name==targetName)
        {
            Debug.Log("查找成功");
            return root;
        }

        Transform tra = null;
        for (int i = 0; i < root.childCount; i++)
        {
            
        }
        //currentNode = FindChild(currentNode, currentNode.name);
        return default(Transform);
    }
}
