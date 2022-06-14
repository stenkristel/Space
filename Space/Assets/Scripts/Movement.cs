using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float Ymovement;

    [SerializeField] private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Ymovement = 3.5f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0.008f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= new Vector3(-0.008f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
        rb.velocity = new Vector3(0, Ymovement, 0);
        }

        if (Ymovement <= 0.5)
        {
            Ymovement = 1;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }

    }

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("Meteorite"))
        {
            Ymovement -= 0.5f;
        }

        if (targetObj.gameObject.tag.Equals("SpeedBoost"))
        {
            Ymovement += 0.5f;
            
        }
        rb.velocity = new Vector3(0, Ymovement, 0);
    }
}
