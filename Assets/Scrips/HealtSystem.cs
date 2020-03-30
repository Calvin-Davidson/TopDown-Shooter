using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class HealtSystem {

    public Action<GameObject> EntityDieEvent;

    public HealtSystem(GameObject Object, int startHP = 100)
    {
        _healt = startHP;
        this.Object = Object;
    }

    private GameObject Object;
    private int _healt;


    public int getHP()
    {
    return _healt;
    }

    public void setHP(int value)
    {
        _healt = value;

        if (_healt <= 0)
        {
            EntityDieEvent(Object);
        }
    }

    public void removeHealth(int value)
    {
        setHP(_healt - value);   
    }

    public void addHealth(int value)
    {
        setHP(_healt + value);
    }
}
