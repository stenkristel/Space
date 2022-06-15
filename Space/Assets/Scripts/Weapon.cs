using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint0;
    public Transform FirePoint1;
    public Transform FirePointR0;
    public Transform FirePointR1;
    public Transform FirePointR2;
    private GameObject bulletPrefab;
    private GameObject bulletPrefab2;
    private GameObject bullets;
    public string bulletname;
    public string bulletname2;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    public float fireRateR = 0.5F;
    private float nextFireR = 0.0F;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bulletPrefab, FirePoint0.position, FirePoint0.rotation);
            Instantiate(bulletPrefab, FirePoint1.position, FirePoint1.rotation);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time > nextFireR)
        {
            nextFireR = Time.time + fireRateR;
            bullets = Instantiate(bulletPrefab2, FirePointR1.position, FirePointR1.rotation);
            Instantiate(bulletPrefab, FirePointR0.position, FirePointR0.rotation);
            Instantiate(bulletPrefab2, FirePointR2.position, FirePointR2.rotation);
        }

    }

    private void Start()
    {
        bulletPrefab = GameObject.Find(bulletname);
        bulletPrefab2 = GameObject.Find(bulletname2);
    }


}
