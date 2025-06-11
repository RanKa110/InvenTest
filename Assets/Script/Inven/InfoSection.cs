using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoSection : MonoBehaviour
{
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI engNameTxt;

    public Image icon;
    public GameObject equipIcon;

    public TextMeshProUGUI effect;

    public TextMeshProUGUI desTxt;

    public ItemDataInstance selectdItem;

    public GameObject equipBtn;
    public GameObject unequipBtn;

    public void UpdateInfo()
    {
        if (selectdItem == null) return;


        nameTxt.text = selectdItem.name;
        engNameTxt.text = selectdItem.engName;

        icon.sprite = selectdItem.icon;

        if(selectdItem.isEquip) equipIcon.SetActive(true);
        else equipIcon.SetActive(false);
    
        desTxt.text = selectdItem.des;

        if (!selectdItem.isEquip)
        {
            equipBtn.SetActive(true);
            unequipBtn.SetActive(false);
        }
        else
        {
            equipBtn.SetActive(false);
            unequipBtn.SetActive(true);
        }
    }

    public void Equip()
    {
        if(selectdItem.itemType == ItemType.weapon)
        {
            if(GameManager.instance.playerManager.weapon != null)
            {
                GameManager.instance.playerManager.weapon.isEquip = false;
                GameManager.instance.playerManager.weapon = null;
            }

            GameManager.instance.playerManager.weapon = selectdItem;
        }
        else if(selectdItem.itemType == ItemType.armor)
        {
            if (GameManager.instance.playerManager.armor != null)
            {
                GameManager.instance.playerManager.armor.isEquip = false;
                GameManager.instance.playerManager.armor = null;
            }

            GameManager.instance.playerManager.armor = selectdItem;
        }
        else if(selectdItem.itemType == ItemType.accessories)
        {
            if (GameManager.instance.playerManager.accessories != null)
            {
                GameManager.instance.playerManager.accessories.isEquip = false;
                GameManager.instance.playerManager.accessories = null;
            }

            GameManager.instance.playerManager.accessories = selectdItem;
        }
        else if(selectdItem.itemType == ItemType.relic)
        {
            if (GameManager.instance.playerManager.relic != null)
            {
                GameManager.instance.playerManager.relic.isEquip = false;
                GameManager.instance.playerManager.relic = null;
            }

            GameManager.instance.playerManager.relic = selectdItem;
        }
        selectdItem.isEquip = true;

        UpdateInfo();
    }

    public void UnEquip()
    {
        if (selectdItem.itemType == ItemType.weapon)
        {
            GameManager.instance.playerManager.weapon = null;
        }
        else if (selectdItem.itemType == ItemType.armor)
        {
            GameManager.instance.playerManager.armor = null;
        }
        else if (selectdItem.itemType == ItemType.accessories)
        {
            GameManager.instance.playerManager.accessories = null;
        }
        else if (selectdItem.itemType == ItemType.relic)
        {
            GameManager.instance.playerManager.relic = null;
        }
        selectdItem.isEquip = false;

        UpdateInfo();
    }

}
