using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemiesKilled : MonoBehaviour
{
    private TextMeshProUGUI text;
    private PlayerManager _PlayerManager;

    void Start()
    {
        text = GameObject.Find("Kills").GetComponent<TextMeshProUGUI>();
        _PlayerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
        _PlayerManager.playerData.EnemyKilled += UpdateText;
    }


    public void UpdateText()
    {
        text.text = _PlayerManager.playerData.getEnemiesKilled().ToString();
    }
}
