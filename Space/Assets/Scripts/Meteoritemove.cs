using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoritemove : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed, 0, 0);
    }

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("borderR"))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
        }
        if (targetObj.gameObject.tag.Equals("borderL"))
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }

    }
}
