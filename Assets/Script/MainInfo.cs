using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainInfo : MonoBehaviour
{
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI levelTxt;
    public TextMeshProUGUI goldTxt;

    public TextMeshProUGUI atkTxt;
    public TextMeshProUGUI defTxt;
    public TextMeshProUGUI hpTxt;
    public TextMeshProUGUI critTxt;

    public void UpdateStatInfo()
    {
        var player = GameManager.instance.playerManager;

        nameTxt.text = player.name.ToString();
        levelTxt.text = player.level.ToString();
        goldTxt.text = player.gold.ToString();

        atkTxt.text = player.atk.ToString();
        defTxt.text = player.def.ToString();
        hpTxt.text = player.hp.ToString();
        critTxt.text = player.crit.ToString();
    }
}
