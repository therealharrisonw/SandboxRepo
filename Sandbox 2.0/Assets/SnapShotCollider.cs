using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapShotCollider : MonoBehaviour
{
    public AudioMixerSnapshot night;
    public AudioMixerSnapshot day;
    bool isNight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            if (!isNight)
            {
                night.TransitionTo(0.5f);
                isNight = true;
            }
            else if (isNight)
            {
                day.TransitionTo(0.5f);
                isNight = false;
            }
        }
    }
}
