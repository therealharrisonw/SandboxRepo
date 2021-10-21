using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightingShoot : MonoBehaviour
{
    XRGrabInteractable GI;
    [SerializeField]
    GameObject zapOrb;
    [SerializeField]
    Transform spawnpoint;
    // Start is called before the first frame update
    void Awake()
    {
        GI = GetComponent<XRGrabInteractable>();
        GI.activated.AddListener(SpawnZapOrb);
    }

    private void SpawnZapOrb(ActivateEventArgs arg0)
    {
        Instantiate(zapOrb, spawnpoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
