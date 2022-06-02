using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint0;
    public Transform FirePoint1;
    public Transform FirePoint2;
    public Transform FirePoint3;
    public GameObject bulletPrefab0;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Shoot();
        }
    }
    
    void Shoot()
    {
        Instantiate(bulletPrefab0, FirePoint0.position, FirePoint0.rotation);
        Instantiate(bulletPrefab1, FirePoint1.position, FirePoint1.rotation);
        Instantiate(bulletPrefab2, FirePoint2.position, FirePoint2.rotation);
        Instantiate(bulletPrefab3, FirePoint3.position, FirePoint3.rotation);
    }
}
