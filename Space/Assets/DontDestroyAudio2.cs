using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio2 : MonoBehaviour
{
    public static DontDestroyAudio2 instance;

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
}
