using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteDestroy : MonoBehaviour
{
    public Transform DropLocation;
    private GameObject DropPrefab;
    public string Dropname;
    private float DropRate = (0.30f);
    public float speed;
    public Rigidbody rb;

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
        }
            
        if (targetObj.gameObject.tag.Equals("Bullet"))
        {
            if (Random.Range(0f, 1f) <= DropRate)
            {
                Instantiate(DropPrefab, DropLocation.position, DropLocation.rotation);
            }
            Destroy(gameObject);
        }

        speed = speed - (speed * 2);

      



    }

    void Start()
    {
        speed = Random.Range(0.5f, 3.5f);
        DropPrefab = GameObject.Find(Dropname);
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }

}
