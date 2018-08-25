using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[Serializable]
public class Actor : IPrototypable
{
    public string name;
    public Sprite icon;
    public List<ScriptableComponent> components;

    public void Mutate<T>(T data)
    {
        float random = UnityEngine.Random.Range(0, 1000);
        Item parent = data as Item;
        StringBuilder builder = new StringBuilder();
        name = builder.Append(this.ToString()).Append(" ").Append(name).Append(" ").Append(parent.name).Append(" ").Append(random.ToString()).ToString();
    }

    public void RunComponents(GameObject g)
    {
        components.ForEach( c => c.Run(g));
    }
}
