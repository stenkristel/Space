using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteDestroy : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        GameObject meteorite = GameObject.Find("Meteorite");
        GameObject PlayerL = GameObject.Find("PlayerL");
        GameObject PlayerR = GameObject.Find("PlayerR");
        
    }
}
