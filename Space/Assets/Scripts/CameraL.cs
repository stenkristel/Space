using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraL : MonoBehaviour
{
    public float YdistanceL;
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("PlayerL");
        YdistanceL = 1.6f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 setPosition = transform.position;
        setPosition.y = player.transform.position.y + YdistanceL;
        setPosition.z = player.transform.position.z - 10;
        transform.position = setPosition;
    }
}
