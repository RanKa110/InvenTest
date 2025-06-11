using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public ItemDataInstance itemData = null;
    public GameObject slotIcon;
    public GameObject equipIcon;

    public GameObject infoSection;

    private void Start()
    {
        if(itemData.item != null)
        {
            slotIcon.GetComponent<Image>().sprite = itemData.item.icon;
        }
    }

    private void OnEnable()
    {
        if (itemData == null) return;
        
        itemData = new ItemDataInstance(itemData.item);
    }

    public void CheckInfo()
    {
        infoSection.GetComponent<InfoSection>().selectdItem = itemData;
        infoSection.GetComponent<InfoSection>().UpdateInfo();
    }

    public void UpdateState()
    {
        if (itemData == null) return;

        if (!slotIcon.activeInHierarchy) slotIcon.SetActive(true);
      
        if (itemData.item.isEquip) equipIcon.SetActive(true);
        else equipIcon.SetActive(false);

        slotIcon.GetComponent<Image>().sprite = itemData.icon;
    }
}
