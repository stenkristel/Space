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
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPrefab2;
    public string bulletname;
    public string bulletname2;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    public float fireRateR = 0.5F;
    private float nextFireR = 0.0F;
    public AudioSource audioSource;
    public AudioClip shootingAudioClipL;
    public AudioClip shootingAudioClipR;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            audioSource.PlayOneShot(shootingAudioClipR);
            Instantiate(bulletPrefab, FirePoint0.position, FirePoint0.rotation);
            Instantiate(bulletPrefab, FirePoint1.position, FirePoint1.rotation);
            Instantiate(bulletPrefab, FirePoint2.position, FirePoint2.rotation);
            Instantiate(bulletPrefab, FirePoint3.position, FirePoint3.rotation);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time > nextFireR)
        {
            nextFireR = Time.time + fireRateR;
            audioSource.PlayOneShot(shootingAudioClipL);
            Instantiate(bulletPrefab2, FirePointR1.position, FirePointR1.rotation);
            Instantiate(bulletPrefab, FirePointR0.position, FirePointR0.rotation);
            Instantiate(bulletPrefab2, FirePointR2.position, FirePointR2.rotation);
        }

    }
}