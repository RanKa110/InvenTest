using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //    ������ �����ϴٸ� private�� ������
    //    �̰� ����Ʈ�� ���°� �� �� ������
    public ItemDataInstance weapon = null;
    public ItemDataInstance armor = null;
    public ItemDataInstance accessories = null;
    public ItemDataInstance relic = null;

    public float atk;
    public float def;
    public float hp;
    public float crit;

    public int level;
    public string name;
    public int gold;

    public GameObject weaponSprite;
    public GameObject armorSprite;


}
