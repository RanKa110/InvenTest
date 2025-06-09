using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UIManager uiManager;
    public PlayerItemDataManager playerDataManager;
    public PlayerManager playerManager;
     


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        uiManager = gameObject.GetComponent<UIManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();
        playerDataManager = playerDataManager.GetComponent<PlayerItemDataManager>();
    }
}
