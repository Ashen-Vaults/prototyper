using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Tag")]
public abstract class ScriptableComponent : ScriptableObject 
{ 
    public abstract void Run(GameObject g);
}
