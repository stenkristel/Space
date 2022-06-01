using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(0.008f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= new Vector3(-0.008f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 3.7f, 0);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
    }
}
