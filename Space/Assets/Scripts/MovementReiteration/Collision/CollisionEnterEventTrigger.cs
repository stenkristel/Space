using System;
using System.Collections;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEnterEventTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent onMeteoriteCollisionEnter;
    [SerializeField] private UnityEvent onUfoCollisionEnter;
    [SerializeField] private UnityEvent onSpeedBoostCollisionEnter;
    [SerializeField] private UnityEvent onBigSpeedBoostCollisionEnter;
    [SerializeField] private UnityEvent onRatCollisionEnter;

    //collision detection niet meegenomen in de refactor, alleen hoe het interact met het movement systeem
    void OnCollisionEnter(Collision targetObj)
    {
        switch (targetObj.gameObject.tag)
        {
            case "Meteorite":
                onMeteoriteCollisionEnter?.Invoke();
                break;
            case "ufo":
                onUfoCollisionEnter?.Invoke();
                break;
            case "SpeedBoost":
                onSpeedBoostCollisionEnter?.Invoke();
                break;
            case "BigSpeedBoost":
                onBigSpeedBoostCollisionEnter?.Invoke();
                break;
            case "Rat":
                onRatCollisionEnter?.Invoke();
                break;
        }
    }
}
