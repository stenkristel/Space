using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleflashL : MonoBehaviour
{
    public Renderer rend;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            StartCoroutine(waiter());
        }
    }

     IEnumerator waiter()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        yield return new WaitForSeconds(0.2f);
        rend.enabled = false;
    }
}
