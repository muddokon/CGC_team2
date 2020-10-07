﻿using System;
using UnityEngine;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public float InitialValue;

    [NonSerialized]
    public float RuntimeValue;

    public void OnAfterDeserialize()
    {
        InitialValue = RuntimeValue;
    }

    public void OnBeforeSerialize()
    {
        RuntimeValue = InitialValue;
    }
}