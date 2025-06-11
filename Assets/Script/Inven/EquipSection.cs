using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipSection : MonoBehaviour
{
    public GameObject weaponSection;
    public GameObject armorSection;
    public GameObject accessoriesSection;
    public GameObject relicSection;

    public Sprite[] defaultSprite;


    public void UpdateEquipSection()
    {
        CheckItemState();
        //    ����� ������ ���������� �Ǵµ�
        //    �� ���� �ȹٲ�� ��������Ʈ�� �ȹٲ���...
        //    ���� �ٲ���� �̷���

        CheckItemEquip();
    }

    void CheckItemEquip()
    {
        var player = GameManager.instance.playerManager;

        if (player.weapon != null)
        {
            weaponSection.GetComponent<Image>().sprite = player.weapon.icon;
            SetIconColor(true, weaponSection);
        }
        if (player.armor != null)
        {
            armorSection.GetComponent<Image>().sprite = player.armor.icon;
            SetIconColor(true, armorSection);
        }
        if (player.accessories != null)
        {
            accessoriesSection.GetComponent<Image>().sprite = player.accessories.icon;
            SetIconColor(true, accessoriesSection);
        }
        if (player.relic != null)
        {
            relicSection.GetComponent<Image>().sprite = player.relic.icon;
            SetIconColor(true, relicSection);
        }
    }

    void CheckItemState()
    {
        //    �̰� ���� �ٲ��ִ°ǵ�...
        var player = GameManager.instance.playerManager;

        if (player.weapon == null)
        {
            weaponSection.GetComponent<Image>().sprite = defaultSprite[0];
            SetIconColor(false, weaponSection);
        }
        if (player.armor == null)
        {
            armorSection.GetComponent<Image>().sprite = defaultSprite[1];
            SetIconColor(false, armorSection);
        }
        if (player.accessories == null)
        {
            accessoriesSection.GetComponent<Image>().sprite = defaultSprite[2];
            SetIconColor(false, accessoriesSection);
        }
        if (player.relic == null)
        {
            relicSection.GetComponent<Image>().sprite = defaultSprite[3];
            SetIconColor(false, relicSection);
        }
    }

    void SetIconColor(bool isEquip, GameObject iconObj)
    {
        if (isEquip)
        {
            iconObj.GetComponent<Image>().color = Color.white;
        }
        else
        {
            iconObj.GetComponent<Image>().color = new Color(96, 96, 96);
        }
    }
}
