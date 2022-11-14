using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Controller : MonoBehaviour
{
    AudioSource Audio;
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Audio.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Audio.Stop();
        }
    }
}
