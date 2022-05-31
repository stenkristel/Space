using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player"); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.y + 0.8f, player.transform.position.z - 10);
    }

}