using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IvenManager : MonoBehaviour
{
    public TextMeshProUGUI AtkTxt;
    public TextMeshProUGUI defTxt;
    public TextMeshProUGUI hpTxt;
    public TextMeshProUGUI critTxt;

    public GameObject weaponIcon;
    public GameObject armorIcon;
    public GameObject accessoriesIcon;
    public GameObject relicIcon;

    public List<GameObject> invenSlots;

    private void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void TestInit()
    {
        foreach(var slot in invenSlots)
        {
            if(slot.GetComponent<Slot>().itemData != null)
            {
                slot.GetComponent<Slot>().UpdateState();
            }
        }
    }

    private void OnEnable()
    {
        TestInit();
    }

    void addItem(ItemDataInstance itemDataInstance)
    {
        for (int i = 0; i < invenSlots.Count; i++)
        {
            //    만약 !=을 넣을려면 스택이 가능하게 만들어야 한다.
            if (invenSlots[i].GetComponent<Slot>().itemData == null)
            {
                invenSlots[i].GetComponent<Slot>().itemData = itemDataInstance;
                
            }
        }
    }

   
}
