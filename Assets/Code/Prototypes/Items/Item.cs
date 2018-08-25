using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item 
{
    public string name;
    public Sprite icon;
    public float cost;
    
}

public class Gun : IWeapon
{
    public void Attack()
    {
        throw new NotImplementedException();
    }
}
