using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo : MonoBehaviour
{
    public Transform DropLocation;
    private GameObject DropPrefab;
    public string Dropname;
    public float speed;
    public float health;
    public GameObject Explosion;
    public Renderer rend;
    public Collider coll;
    public Rigidbody rb;
    public AudioSource audioSource;
    public AudioClip ufoAudioClip;
    public AudioClip playerAudioClip;


    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("Player"))
        {
            audioSource.PlayOneShot(playerAudioClip);
            rend = GetComponent<Renderer>();
            rend.enabled = false;
            coll = GetComponent<Collider>();
            coll.enabled = false;
            StartCoroutine(waiter());
            speed = 0f;
        }

        if (targetObj.gameObject.tag.Equals("Bullet"))
        {
            audioSource.PlayOneShot(ufoAudioClip);
            health = health - 1f;
            
            if (health <= 0f)
            {
                rend = GetComponent<Renderer>();
                rend.enabled = false;
                coll = GetComponent<Collider>();
                coll.enabled = false;
                StartCoroutine(waiter());
                speed = 0f;
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
        health = 2f;
        speed = (0.5f);
        DropPrefab = GameObject.Find(Dropname);
        rb = GetComponent<Rigidbody>();
        if (Random.Range(0f, 1f) <= 0.5)
        {
            speed = speed - (speed * 2);
        }
    }

    void Update()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }
}
