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

    float atk;
    float def;
    float hp;
    float crit;

    int level;
    string name;
    int gold;

    public GameObject weaponSprite;
    public GameObject armorSprite;

    private void Awake()
    {
       
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
