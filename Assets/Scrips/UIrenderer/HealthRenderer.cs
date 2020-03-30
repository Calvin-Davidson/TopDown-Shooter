using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthRenderer : MonoBehaviour
{
    PlayerManager playerManager;
    private Slider _HealthSlider;
    void Start()
    {
        _HealthSlider = GameObject.Find("PlayerHealtBar").GetComponent<Slider>();
        playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
        GameObject.Find("PlayerHealtBar").GetComponent<Slider>();
    }

    public void UpdateHealtBar()
    {
        float value = playerManager.playerData.healtSystem.getHP();
        value /= 100;
        Debug.Log(value);
        _HealthSlider.value = value;

    }
}
