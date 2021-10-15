using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playback : MonoBehaviour
{
    public AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnFire()
    {
        audioSource.Play();
    }

    void OnPlayAudio()
    {
        Debug.Log("Cue the Music");
        audioSource.Play();
    }
}
