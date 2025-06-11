using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Data/Item", menuName = "Scriptable/Item")]
public class ItemData : ScriptableObject
{

    public Sprite icon;

    public int itemNum;
    public ItemType itemType;

    public string name;
    public string engName;

    [TextArea(3, 5)]
    public string des;

    public bool isEquip;


    public float hp;
}
