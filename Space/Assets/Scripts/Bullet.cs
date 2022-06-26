using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public float bulletlife = 2f;
    public float delay = 2f;
    public float speed = 20f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Meteorite")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "ufo")
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        Destroy(gameObject, 1);
    }
}

