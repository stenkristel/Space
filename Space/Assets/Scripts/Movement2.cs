using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    [SerializeField] private float speed;
    private float Ymovement;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject SpriteFast;
    [SerializeField] private GameObject SpriteMedium;
    [SerializeField] private GameObject SpriteSlow;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Ymovement = 3.5f;
    }
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

        if (Ymovement <= 1.5f)
        {
            Ymovement = 1.5f;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }

        if (Ymovement >= 5)
        {
            Ymovement = 5;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }

        if (Ymovement >= 0)
        {
            if (Ymovement <= 2)
            {
                SpriteSlow.SetActive(true);
                SpriteMedium.SetActive(false);
                SpriteFast.SetActive(false);
            }
            if (Ymovement >= 3)
            {
                SpriteFast.SetActive(true);
                SpriteSlow.SetActive(true);
                SpriteMedium.SetActive(false);
            }
            if (Ymovement <= 3)
            {
                if (Ymovement >= 2)
                {
                    SpriteMedium.SetActive(true);
                    SpriteSlow.SetActive(true);
                    SpriteFast.SetActive(false);
                }
            }
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
