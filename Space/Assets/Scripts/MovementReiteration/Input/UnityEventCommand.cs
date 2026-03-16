using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventCommand : BaseCommand
{
    [SerializeField] private UnityEvent onExecute;
    public override void Execute()
    {
        onExecute?.Invoke();
    }
}
