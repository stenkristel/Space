using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public struct MinMaxEventStruct
{
    public float MinValue;
    public float MaxValue;
    public UnityEvent onInRange;
}
