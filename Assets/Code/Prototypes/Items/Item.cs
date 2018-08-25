using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[Serializable]
public class Item : IPrototypable
{
    public string name;
    public Sprite icon;
    public float cost;
    public float sight;
    public GameObject prefab;

    public void Mutate<T>(T data)
    {
        float random = UnityEngine.Random.Range(0, 1000);
        Actor parent = data as Actor;
        StringBuilder builder = new StringBuilder();

        name = builder.Append(this.ToString()).Append(" ").Append(name).Append(" ").Append(parent.name).Append(" ").Append(random.ToString()).ToString();
        cost = random / Time.deltaTime;
        sight = cost * UnityEngine.Random.Range(1,5);
    }
}
