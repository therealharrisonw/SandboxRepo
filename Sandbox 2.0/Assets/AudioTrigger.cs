using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource triggerAudio;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        triggerAudio.Play();
    }
}
