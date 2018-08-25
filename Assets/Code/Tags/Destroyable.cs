using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Tag/IDestroyable")]
public class Destroyable : ScriptableComponent
{
    public override void Run(GameObject g)
    {
        Destroy(g);
        Debug.Log("Destroy");
    }
}
