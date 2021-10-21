using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireShoot : MonoBehaviour
{
    XRGrabInteractable GI;
    [SerializeField]
    GameObject fireball;
    [SerializeField]
    Transform spawnpoint;
    // Start is called before the first frame update
    void Awake()
    {
        GI = GetComponent<XRGrabInteractable>();
        GI.activated.AddListener(SpawnFireBall);
    }

    private void SpawnFireBall(ActivateEventArgs arg0)
    {
        Instantiate(fireball, spawnpoint.position, Quaternion.identity);
    }

    
}
