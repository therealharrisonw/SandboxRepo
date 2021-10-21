using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ElementShoot : MonoBehaviour
{
    XRGrabInteractable GI;
    [SerializeField]
    GameObject waterOrb;
    [SerializeField]
    GameObject lightningOrb;
    [SerializeField]
    Transform spwnpoint;
    private bool element = true; 
    // Start is called before the first frame update
    void Awake()
    {
        GI = GetComponent<XRGrabInteractable>();
        GI.activated.AddListener(SpawnElements);
    }

    private void SpawnElements(ActivateEventArgs arg0)
    {
        if (element)
        {
            Instantiate(waterOrb, spwnpoint.position, Quaternion.identity);
            element = false;
        }
        else
        {
            Instantiate(lightningOrb, spwnpoint.position, Quaternion.identity);
            element = true;
        }
        
        
    }

    
    
}
