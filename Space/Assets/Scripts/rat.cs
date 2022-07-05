using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rat : MonoBehaviour
{
    public float speed;
    public GameObject Explosion;
    public Renderer rend;
    public Collider coll;
    public Rigidbody rb;
    public AudioSource audioSource;
    public AudioClip ratAudioClip;

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("Player"))
        {
            audioSource.PlayOneShot(ratAudioClip);
            rend = GetComponent<Renderer>();
            rend.enabled = false;
            coll = GetComponent<Collider>();
            coll.enabled = false;
            StartCoroutine(waiter());
            speed = 0f;
        }

        if (targetObj.gameObject.tag.Equals("Bullet"))
        {
            speed = speed - (speed * 2);
        }
        speed = speed - (speed * 2);
        if (speed > 0)
        {
            gameObject.transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
        }
        if (speed < 0)
        {
            gameObject.transform.localScale = new Vector3(-0.08f, 0.08f, 0.08f);
        }
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
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }
}
