using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float Ymovement;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Ymovement = 3.5f;
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position -= Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.position -= Vector3.left * Time.deltaTime * speed;
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

        if (Ymovement >= 5f)
        {
            Ymovement = 4.5f;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }

    }

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("Meteorite"))
        {
            Ymovement -= 1f;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }

        if (targetObj.gameObject.tag.Equals("SpeedBoost"))
        {
            Ymovement += 0.5f;
            rb.velocity = new Vector3(0, Ymovement, 0);

        }
        
    }
}
