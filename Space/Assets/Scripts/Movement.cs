using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Debug.Log(gameObject.name);
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= new Vector3(-0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 5, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, -5, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
    }
}