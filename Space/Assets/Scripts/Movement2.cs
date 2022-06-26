using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    private float Ymovement;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject SpriteFast;
    [SerializeField] private GameObject SpriteMedium;
    [SerializeField] private GameObject SpriteSlow;
    [SerializeField] private GameObject BiggestflameLeft;
    [SerializeField] private GameObject BiggestflameRight;
    [SerializeField] private GameObject Bigflame;
    [SerializeField] private GameObject Mediumflame;
    [SerializeField] private GameObject Littleflame;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Ymovement = 0f;
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
            if (Ymovement < 1)
            {
                Ymovement = 3.6f;
                rb.velocity = new Vector3(0, Ymovement, 0);
            }

        }

        if (Ymovement <= 1.5f)
        {
            if (Ymovement >= 0.1)
            {
                Ymovement = 1.5f;
                rb.velocity = new Vector3(0, Ymovement, 0);
            }


        }

        if (Ymovement > 5.5f)
        {
            Ymovement = 5.5f;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }


        if (Ymovement >= 0.1f)
        {
            if (Ymovement <= 2.4f)
            {
                SpriteSlow.SetActive(true);
                SpriteMedium.SetActive(false);
                SpriteFast.SetActive(false);

                BiggestflameRight.SetActive(false);
                BiggestflameLeft.SetActive(false);
                Bigflame.SetActive(false);
                Mediumflame.SetActive(false);
                Littleflame.SetActive(true);
                
            }
            if (Ymovement >= 2.5f)
            {
                if (Ymovement <= 3.5f)
                {
                    SpriteMedium.SetActive(true);
                    SpriteSlow.SetActive(false);
                    SpriteFast.SetActive(false);

                    BiggestflameRight.SetActive(false);
                    BiggestflameLeft.SetActive(false);
                    Bigflame.SetActive(false);
                    Mediumflame.SetActive(true);
                    Littleflame.SetActive(false);
                }
                if (Ymovement >= 3.6f)
                {
                    if (Ymovement <= 4.5f)
                    {
                        SpriteFast.SetActive(true);
                        SpriteSlow.SetActive(false);
                        SpriteMedium.SetActive(false);

                        BiggestflameRight.SetActive(false);
                        BiggestflameLeft.SetActive(false);
                        Bigflame.SetActive(true);
                        Mediumflame.SetActive(false);
                        Littleflame.SetActive(false);

                    }
                    if (Ymovement >= 4.6)
                    {
                        SpriteFast.SetActive(true);
                        SpriteSlow.SetActive(false);
                        SpriteMedium.SetActive(false);

                        BiggestflameRight.SetActive(true);
                        BiggestflameLeft.SetActive(true);
                        Bigflame.SetActive(false);
                        Mediumflame.SetActive(false);
                        Littleflame.SetActive(false);
                    }

                }

            }
        }



    }

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("Meteorite"))
        {
            Ymovement -= 0.7f;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }
        if (targetObj.gameObject.tag.Equals("ufo"))
        {
            Ymovement -= 1f;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }

        if (targetObj.gameObject.tag.Equals("SpeedBoost"))
        {
            Ymovement += 0.5f;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }
        if (targetObj.gameObject.tag.Equals("BigSpeedBoost"))
        {
            Ymovement += 1f;
            rb.velocity = new Vector3(0, Ymovement, 0);
        }

    }
}
