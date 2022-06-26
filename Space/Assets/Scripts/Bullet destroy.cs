using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletdestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
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
}
