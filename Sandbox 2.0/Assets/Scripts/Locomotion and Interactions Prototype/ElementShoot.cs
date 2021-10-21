using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ElementShoot : MonoBehaviour
{
    XRGrabInteractable GI; //used for refrencing grab interacatables
    [SerializeField]
    GameObject waterOrb; //allows me to set the gameobject to be spawned for waterOrb
    [SerializeField]
    GameObject lightningOrb;//allows me to set the gameobject to be spawned for lightning orb
    [SerializeField]
    Transform spwnpoint; //allows me to set the transform for the orbs to spawn out of the end of the gun.
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
