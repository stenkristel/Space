using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraR : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerR");

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.8f, player.transform.position.z - 10);
        Vector3 setPosition = transform.position;
        setPosition.y = player.transform.position.y + 1.3f;
        setPosition.z = player.transform.position.z - 10;
        transform.position = setPosition;
    }
}
