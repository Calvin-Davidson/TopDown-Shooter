using UnityEngine;

public class Shoot : MonoBehaviour
{
    private PlayerManager playerManager;
    private void Start()
    {
        playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
    }

    private void Update()
    {
        if (playerManager != null)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (playerManager.playerData.currentWeapon != null)
                {
                    playerManager.playerData.currentWeapon.UseWeapon();

                } else
                {
                    Debug.LogError("weapon is null");
                }
            }
        }
        else
        {
            Debug.Log("playermanager = null");
        }
    }
}