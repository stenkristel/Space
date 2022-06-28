using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpaceDestroy : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }

    public void Launch()
    {

    }
}

