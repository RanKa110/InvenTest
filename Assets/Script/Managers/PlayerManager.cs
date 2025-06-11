using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //    다음에 가능하다면 private로 만들어보자
    //    이거 리스트로 묶는거 될 것 같은데
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
