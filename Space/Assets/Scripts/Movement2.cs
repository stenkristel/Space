using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    [SerializeField] private float speed;
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.position -= Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
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

        if (Ymovement >= 5.5f)
        {
            Ymovement = 5;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }

    }

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("Meteorite"))
        {
            rb.velocity = new Vector3(0, Ymovement, 0);
            Ymovement -= 1;
        }

        if (targetObj.gameObject.tag.Equals("SpeedBoost"))
        {
            Ymovement += 0.5f;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }
        
    }
}
