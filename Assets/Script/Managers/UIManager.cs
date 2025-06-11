using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject statBtnObj;
    public GameObject invenBtnObj;

    public GameObject[] ExitBtnObj;

    public GameObject statUI;
    public GameObject invenUI;

    public GameObject infoUI;

    public void OnInvenUI()
    {
        if (statBtnObj != null && invenBtnObj != null)
        {
            statBtnObj.SetActive(false);
            invenBtnObj.SetActive(false);
        }

        invenUI.SetActive(true);
    }

    public void OnStatUI()
    {
        if (statBtnObj != null && invenBtnObj != null)
        {
            statBtnObj.SetActive(false);
            invenBtnObj.SetActive(false);
        }

        statUI.SetActive(true);
    }

    public void UIExit()
    {
        if (statBtnObj != null && invenBtnObj != null)
        {
            statBtnObj.SetActive(true);
            invenBtnObj.SetActive(true);
        }

        if(invenUI.activeInHierarchy) invenUI.SetActive(false);
        if(statUI.activeInHierarchy) statUI.SetActive(false);
    }




    //==============================================================
    //    ¾À ·Îµå °ü·Ã
    //==============================================================
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "SampleScene")
        {
            Button statBtn = statBtnObj.GetComponent<Button>();
            Button invenBtn = invenBtnObj.GetComponent<Button>();

            statBtn.onClick.RemoveAllListeners();
            statBtn.onClick.AddListener(OnStatUI);

            invenBtn.onClick.RemoveAllListeners();
            invenBtn.onClick.AddListener(OnInvenUI);

            foreach(GameObject btns in ExitBtnObj)
            {
                Button exitButton = btns.GetComponent<Button>();
                exitButton.onClick.RemoveAllListeners();
                exitButton.onClick.AddListener(UIExit);
            }
        }
    }
}
