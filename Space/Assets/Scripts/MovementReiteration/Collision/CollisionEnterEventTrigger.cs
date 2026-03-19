using System;
using System.Collections;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEnterEventTrigger : MonoBehaviour
{
    public SerializedDictionary<ICollidable, UnityEvent> dictionary = new SerializedDictionary<ICollidable, UnityEvent>();
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.TryGetComponent<ICollidable>(out ICollidable collidable)) return;
        if (!dictionary.TryGetValue(collidable, out UnityEvent collisionEvent)) return;
        collisionEvent.Invoke();
    }
}
