using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponR : MonoBehaviour
{
    public Transform FirePointR0;
    public Transform FirePointR1;
    public Transform FirePointR2;
    public GameObject bulletPrefabR0;
    public GameObject bulletPrefabR1;
    public GameObject bulletPrefabR2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ShootR();
        }
    }

    void ShootR()
    {
        Instantiate(bulletPrefabR0, FirePointR0.position, FirePointR0.rotation);
        Instantiate(bulletPrefabR1, FirePointR1.position, FirePointR1.rotation);
        Instantiate(bulletPrefabR2, FirePointR2.position, FirePointR2.rotation);
    }
}
