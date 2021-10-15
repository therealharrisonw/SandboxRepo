using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class bubbleshoot : MonoBehaviour
{
    XRGrabInteractable GI;
    [SerializeField]
    GameObject bubblePrefab;
    [SerializeField]
    Transform spwnpoint;
    // Start is called before the first frame update
    void Awake()
    {
        GI = GetComponent<XRGrabInteractable>();
        GI.activated.AddListener(SpawnBubbles);
    }

    private void SpawnBubbles(ActivateEventArgs arg0)
    {
        Instantiate(bubblePrefab, spwnpoint.position, Quaternion.identity);
    }

    
   
}
