using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    private Weapon _MainWeapon;
    private Weapon _miniGun;
    private PlayerManager _PlayerManager;
    void Awake()
    {
        _MainWeapon = GameObject.Find("Player").GetComponent<Weapon>();
        _PlayerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
        _miniGun = new MiniGun();

        // zodat de speler begint met de main weapon.
        if (_PlayerManager == null)
        {
            Debug.Log("PlayerManager is null");
            return;
        }
        if (_MainWeapon == null)
        {
            Debug.Log("Weapon is null");
            return;
        }
        if (_PlayerManager.playerData == null)
        {
            Debug.Log("PlayerData is null");
            return;
        }
        _PlayerManager.playerData.currentWeapon = _MainWeapon;
    }

    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            if (_MainWeapon == null)
            {
                Debug.Log("Main weapon is null");
                return;
            }
            _PlayerManager.playerData.currentWeapon = _MainWeapon;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (_miniGun == null)
            {
                Debug.Log("MiniGun is null");
                return;
            }
            _PlayerManager.playerData.currentWeapon = _miniGun;
        }
    }
}
