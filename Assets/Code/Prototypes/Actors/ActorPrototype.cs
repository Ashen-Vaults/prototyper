using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Prototypes/Actor")]
public class ActorPrototype : Prototype<Actor>
{
    [SerializeField]
    GameObject g;

    [ContextMenu("Run Components")]
    void RunComponents()
    {
        data.RunComponents(g);
    }
}
