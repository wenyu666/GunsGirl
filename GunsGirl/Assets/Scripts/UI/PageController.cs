using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageController<T> where T:PageBase {

    private PageController() { }
    private static PageController<T> instance;
    public static PageController<T> Instance { get { return instance ?? new PageController<T>(); } }

    private Stack<T> pages = new Stack<T>();

    /// <summary>
    /// 打开页面
    /// </summary>
    public void Push(T t)
    {
        if (pages.Count>0)
        {
            PageBase current = pages.Peek();
            current.OnExit();
        }

        t.OnEnter();
        pages.Push(t);
    }

    /// <summary>
    /// 关闭页面
    /// </summary>
    public void Pop()
    {
        if (pages.Count>1)
        {
            PageBase current = pages.Pop();
            current.OnExit();

            current = pages.Peek();
            current.OnEnter();

            return;
        }

        Debug.LogError("已经最后一个页面了");
    }
}
