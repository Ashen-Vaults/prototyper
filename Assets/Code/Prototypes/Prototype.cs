using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Prototype<T> : ScriptableObject where T : IPrototypable
{
    [SerializeField]
    protected T data;
    public T Data{get {return data;}}

    public T Mutate(IPrototypable spouse)
    {
        T child = Clone();
        child.Mutate(spouse);
        return child;
    }

    public T Clone(bool deepClone = true)
    {
        if(deepClone)
        {
            string json = JsonUtility.ToJson(data);
            return (T)JsonUtility.FromJson<T>(json);
        }   
        else
        {
            return (T)data;
        }
    }
}
