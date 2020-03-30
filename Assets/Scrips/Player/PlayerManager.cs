using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    public PlayerData playerData;

    // Start is called before the first frame update
    void Awake()
    {   
        playerData = new PlayerData(this.gameObject);

        playerData.healtSystem.EntityDieEvent += OnPlayerDie;
    }
    public void EnemyKilled()
    {
        playerData.addEnemiesKilled();
    }

    public void OnPlayerDie(GameObject obj)
    {
        Debug.Log("YOU DEAD");
        SceneManager.LoadScene("YouDied");
    }
}
