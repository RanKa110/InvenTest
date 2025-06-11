using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemDataManager : MonoBehaviour
{
    public List<ItemData> itemDatas = new List<ItemData>();
    public List<ItemDataInstance> items = new List<ItemDataInstance>();

    void Start()
    {
        for(int i = 0; i< itemDatas.Count; i++)
        {
            AddItem(itemDatas[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddItem(ItemData itemData)
    {
        ItemDataInstance newItem = new ItemDataInstance(itemData);
        items.Add(newItem);
    }
}
