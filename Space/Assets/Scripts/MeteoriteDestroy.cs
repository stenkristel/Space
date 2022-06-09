using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteDestroy : MonoBehaviour
{
    public Transform DropLocation;
    private GameObject DropPrefab;
    public string Dropname;
    private float DropRate = (0.70f);
    
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        if (Random.Range(0f, 1f)<=DropRate)
        {
            Instantiate(DropPrefab, DropLocation.position, DropLocation.rotation);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DropPrefab = GameObject.Find(Dropname);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
