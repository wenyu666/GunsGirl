using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 查找工具
/// </summary>
public class TransformHelper : MonoBehaviour
{


    /// <summary>
    /// 查找根节点下的目标子物体
    /// </summary>
    /// <param name="root">根节点</param>
    /// <param name="targetName">想要寻找的子物体的名字</param>
    public static Transform FindChild(Transform root, string name)
    {
        Transform target = root.Find(name);
        if (target!=null){return target;}

        Transform tra=null;
        for (int i = 0; i < root.childCount; i++)
        {
            tra = FindChild(root.GetChild(i), name);

            //找到目标，阻断递归
            if (tra!=null){return tra;}
        }

        return null;
    }

    /// <summary>
    /// 查找根节点下的组件
    /// </summary>
    /// <typeparam name="T">目标组件</typeparam>
    /// <param name="root">根节点</param>
    /// <returns></returns>
    public static T FindChild<T>(Transform root) where T:MonoBehaviour
    {
        T target = root.GetComponentInChildren<T>();
        if (target != null) { return target; }

        T tra = default(T);
        for (int i = 0; i < root.childCount; i++)
        {
            tra = FindChild<T>(root.GetChild(i));

            //找到目标，阻断递归
            if (tra != null) { return tra; }
        }

        return default(T);
    }
}