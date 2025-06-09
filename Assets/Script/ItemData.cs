using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Data/Item", menuName = "Scriptable/Item")]

public class ItemData : ScriptableObject
{
    [SerializeField] int itemNum;
    [SerializeField] ItemType itemType;

    [SerializeField] string name;
    [SerializeField] string engName;

    [TextArea(3, 5)]
    [SerializeField] string des;
    [SerializeField] float itemValue;
    [SerializeField] float itemWeight;
    [SerializeField] int itemStack;

    [SerializeField] bool isIllegal;
    [SerializeField] HAZMAT hazardousType;
}
