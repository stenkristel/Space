using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpaceDestroy : MonoBehaviour
{
    Movement movementL;
    [SerializeField] GameObject PlayerL;
    Movement2 movementR;
    [SerializeField] GameObject playerR;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }

    void Awake()
    {
        movementL = PlayerL.GetComponent<Movement>();
        movementR = playerR.GetComponent<Movement2>();
    }

    public void launch()
    {
        movementL.Ymovement = 3.6f;
        movementR.Ymovement = 3.6f;

        Destroy(gameObject);
    }
}

