using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraL : MonoBehaviour
{

    public GameObject player;

    void Start()
    {
        player = GameObject.Find("PlayerL");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 setPosition = transform.position;
        setPosition.y = player.transform.position.y + 1.7f;
        setPosition.z = player.transform.position.z - 10;
        transform.position = setPosition;
    }
}
