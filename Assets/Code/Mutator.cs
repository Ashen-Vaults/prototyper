using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutator : MonoBehaviour 
{
    [SerializeField] ActorPrototype _parentA;
    [SerializeField] ItemPrototype _parentB;

    [SerializeField] IPrototypable _childItem;

    [ContextMenu("Mutate")]
    void MutatePrototype()
    {
        _childItem = _parentA.Mutate(_parentB.Data);
        _childItem = _parentB.Mutate(_parentA.Data);
        Debug.Log(_childItem.ToString());
    }
}
