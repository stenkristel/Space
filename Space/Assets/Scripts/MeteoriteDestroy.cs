using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteDestroy : MonoBehaviour
{
    public Transform DropLocation;
    private GameObject DropPrefab;
    public string Dropname;
    private float DropRate = (0.30f);
    
    void OnCollisionEnter(Collision targetObj)
    {
        Destroy(gameObject);
        if (targetObj.gameObject.tag.Equals("Bullet"))
        {
            if (Random.Range(0f, 1f) <= DropRate)
            {
                Instantiate(DropPrefab, DropLocation.position, DropLocation.rotation);
            }
        }
        
    }

    void Start()
    {
        DropPrefab = GameObject.Find(Dropname);
    }
}
