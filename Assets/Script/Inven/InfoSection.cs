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

        if (selectdItem.isEquip) equipIcon.SetActive(true);
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
        var player = GameManager.instance.playerManager;

        if (selectdItem.itemType == ItemType.weapon)
        {
            //    너무 중복되고 길다...
            //    함수로 만들 수 있을텐데...
            //    시간이가 없구나... 

            //    거기다 스크립터블 데이터 원본을 쓰는건 위험해서
            //    복사해서 쓰려 했건만은
            //    아직 내 영역이 아니구나....!

            if (player.weapon != null)
            {
                UnEquip();
            }

            player.weapon = selectdItem;
            player.weapon.isEquip = true;
            player.hp += selectdItem.hp;
        }
        else if (selectdItem.itemType == ItemType.armor)
        {
            if (player.armor != null)
            {
                UnEquip();
            }

            player.armor = selectdItem;
            player.armor.isEquip = true;
            player.hp += selectdItem.hp;
        }
        else if (selectdItem.itemType == ItemType.accessories)
        {
            if (    player.accessories != null)
            {
                UnEquip();
            }

            player.accessories = selectdItem;
            player.accessories.isEquip = true;
            player.hp += selectdItem.hp;
        }
        else if (selectdItem.itemType == ItemType.relic)
        {
            if (player.relic != null)
            {
                UnEquip();
            }

            player.relic = selectdItem;
            player.relic.isEquip = true;
            player.hp += selectdItem.hp;
        }
        selectdItem.isEquip = true;

        GameManager.instance.uiManager.infoUI.GetComponent<MainInfo>().UpdateStatInfo();
        GameManager.instance.invenManager.TotalUpdate();
    }

    public void UnEquip()
    {
        var player = GameManager.instance.playerManager;

        if (selectdItem.itemType == ItemType.weapon)
        {
            player.hp -= player.weapon.hp;

            player.weapon.isEquip = false;
            player.weapon = null;
        }
        else if (selectdItem.itemType == ItemType.armor)
        {
            player.hp -= player.armor.hp;

            player.armor.isEquip = false;
            player.armor = null;
        }
        else if (selectdItem.itemType == ItemType.accessories)
        {
            player.hp -= player.accessories.hp;

            player.accessories.isEquip = false;
            player.accessories = null;
        }
        else if (selectdItem.itemType == ItemType.relic)
        {
            player.hp -= player.relic.hp;

            player.relic.isEquip = false;
            player.relic = null;
        }
        selectdItem.isEquip = false;

        GameManager.instance.invenManager.TotalUpdate();
    }

}

