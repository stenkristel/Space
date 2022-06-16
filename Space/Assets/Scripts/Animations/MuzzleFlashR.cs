using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlashR : MonoBehaviour
{
    public Renderer rend;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
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
