using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 将所有需要打开的页面集合存储在该类中
/// </summary>
public class AllPageManager
{
    /*
     
    public enum EPageType { HomePage,EquipmentPage,FriendPage,CombatPage,ShopPage}   
     
    public Dictionary<EPageType, PageBase> pageDic=new Dictionary<EPageType, PageBase>();

    public AllPageManager()
    {
        pageDic[EPageType.EquipmentPage] = GameObject.Find("").GetComponent<Homepage>();
        pageDic[EPageType.EquipmentPage] = GameObject.Find("").GetComponent<EquipmentPage>();
        pageDic[EPageType.EquipmentPage] = GameObject.Find("").GetComponent<FriendPage>();
        pageDic[EPageType.EquipmentPage] = GameObject.Find("").GetComponent<CombatPage>();
        pageDic[EPageType.EquipmentPage] = GameObject.Find("").GetComponent<ShopPage>();
    }

    */

    public static Homepage       homePage      = GameObject.Find("").GetComponent<Homepage>();
    public static EquipmentPage  equipmentPage = GameObject.Find("").GetComponent<EquipmentPage>();
    public static FriendPage     friendPage    = GameObject.Find("").GetComponent<FriendPage>();
    public static CombatPage     combatPage    = GameObject.Find("").GetComponent<CombatPage>();
    public static ShopPage       shopPage      = GameObject.Find("").GetComponent<ShopPage>();

    

}
