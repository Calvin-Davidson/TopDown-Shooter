using System;
using UnityEngine;

public class PlayerData
{
    public Weapon currentWeapon;
    //public Weapon currentWeapon;

    public Action EnemyKilled;

    public PlayerData(GameObject gameobject)
    {
        healtSystem = new HealtSystem(gameobject);
    }

    public HealtSystem healtSystem;
    private int EnemiesKilled = 0;

    public void addEnemiesKilled(int value = 1)
    {
        this.EnemiesKilled += value;

        EnemyKilled();
    }

    public int getEnemiesKilled()
    {
        return EnemiesKilled;
    }

    public int Granates = 3;
}