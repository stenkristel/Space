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
    public GameObject Explosion;
    public Renderer rend;
    public Collider coll;
    public Rigidbody rb;
    public AudioSource audioSource;
    public AudioClip bulletDestroyAudioClip;
    public AudioClip shipHitAudioClip;
    public AudioClip itemDropAudioClip;

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("Player"))
        {
            audioSource.PlayOneShot(shipHitAudioClip);
            rend = GetComponent<Renderer>();
            rend.enabled = false;
            coll = GetComponent<Collider>();
            coll.enabled = false;
            StartCoroutine(waiter());
            speed = 0f;
        }

        if (targetObj.gameObject.tag.Equals("Bullet"))
        {
            audioSource.PlayOneShot(bulletDestroyAudioClip);
            rend = GetComponent<Renderer>();
            rend.enabled = false;
            coll = GetComponent<Collider>();
            coll.enabled = false;
            StartCoroutine(waiter());
            speed = 0f;
            if (Random.Range(0f, 1f) <= DropRate)
            {
                audioSource.PlayOneShot(itemDropAudioClip);
                Instantiate(DropPrefab, DropLocation.position, DropLocation.rotation);
            }

        }

        speed = speed - (speed * 2);
    }

    IEnumerator waiter()
    {
        Explosion.SetActive(true);
        yield return new WaitForSeconds(1f);
        Explosion.SetActive(false);
    }
    void Start()
    {
        speed = Random.Range(0.5f, 3.5f);
        DropPrefab = GameObject.Find(Dropname);
        rb = GetComponent<Rigidbody>();
        if (Random.Range(0f, 1f) <=0.5)
        {
            speed = speed - (speed * 2);
        }
    }

    void Update()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }

}
