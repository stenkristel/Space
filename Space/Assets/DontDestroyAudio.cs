using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyAudio : MonoBehaviour
{
    public static DontDestroyAudio instance;

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SpaceRace")
            DontDestroyAudio.instance.GetComponent<AudioSource>().Pause();
    }
}
