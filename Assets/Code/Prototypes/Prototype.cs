using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Prototype<T> : ScriptableObject 
{
    [SerializeField]
    protected T data;

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
