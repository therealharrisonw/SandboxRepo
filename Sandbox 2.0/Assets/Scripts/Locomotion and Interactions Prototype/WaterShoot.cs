using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WaterShoot : MonoBehaviour
{
    XRGrabInteractable GI;
    [SerializeField]
    GameObject waterOrb;
    [SerializeField]
    Transform spawnpoint;
    // Start is called before the first frame update
    void Awake()
    {
        GI = GetComponent<XRGrabInteractable>();
        GI.activated.AddListener(SpawnWaterOrb);
    }

    private void SpawnWaterOrb(ActivateEventArgs arg0)
    {
        Instantiate(waterOrb, spawnpoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
