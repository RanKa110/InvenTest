using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemDataInstance
{
    public ItemData item;

    public Sprite icon;
    public ItemType itemType;

    public string name;
    public string engName;

    public string des;

    public bool isEquip;

    public ItemDataInstance(ItemData item)
    {
        this.item = item;

        this.icon = item.icon;
        this.itemType = item.itemType;

        this.name = item.name;
        this.engName = item.engName;
        this.des = item.des;

        this.isEquip = item.isEquip;
    }
}
