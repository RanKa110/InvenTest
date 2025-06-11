using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UIManager uiManager;
    public PlayerItemDataManager playerDataManager;
    public PlayerManager playerManager;
    public IvenManager invenManager;



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

        uiManager = uiManager.GetComponent<UIManager>();
        playerManager = playerManager.GetComponent<PlayerManager>();
        playerDataManager = playerDataManager.GetComponent<PlayerItemDataManager>();
        invenManager = invenManager.GetComponent<IvenManager>();
    }

}
