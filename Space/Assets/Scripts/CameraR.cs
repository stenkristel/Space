using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraR : MonoBehaviour
{

    public GameObject player;
    void Start()
    {
        player = GameObject.Find("PlayerR");

    }
    void Update()
    {
        Vector3 setPosition = transform.position;
        setPosition.y = player.transform.position.y + 1.6f;
        setPosition.z = player.transform.position.z - 10;
        transform.position = setPosition;
    }
}
