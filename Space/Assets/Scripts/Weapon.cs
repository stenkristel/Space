using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint0;
    public Transform FirePoint1;
    public Transform FirePoint2;
    public Transform FirePoint3;
    public Transform FirePointR0;
    public Transform FirePointR1;
    public Transform FirePointR2;
    private GameObject bulletPrefab;
    private GameObject bulletPrefab2;
    public string bulletname;
    public string bulletname2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(bulletPrefab, FirePoint0.position, FirePoint0.rotation);
            Instantiate(bulletPrefab, FirePoint1.position, FirePoint1.rotation);
            Instantiate(bulletPrefab, FirePoint2.position, FirePoint2.rotation);
            Instantiate(bulletPrefab, FirePoint3.position, FirePoint3.rotation);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Instantiate(bulletPrefab2, FirePointR0.position, FirePointR0.rotation);
            Instantiate(bulletPrefab, FirePointR1.position, FirePointR1.rotation);
            Instantiate(bulletPrefab2, FirePointR2.position, FirePointR2.rotation);
        }

    }

    private void Start()
    {
        bulletPrefab = GameObject.Find(bulletname);
        bulletPrefab2 = GameObject.Find(bulletname2);
    }
}
