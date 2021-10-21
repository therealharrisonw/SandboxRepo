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
    private bool element = true; //bool used for switching the ammo type

    // Start is called before the first frame update
    void Awake()
    {
        GI = GetComponent<XRGrabInteractable>(); //tells the code to grab the components from the XR Grab Interactable 
        GI.activated.AddListener(SpawnElements); //tells the script tp add a listner for when the trigger is fired
    }

    private void SpawnElements(ActivateEventArgs arg0)
    {
        if (element) //if element is true do this
        {
            Instantiate(waterOrb, spwnpoint.position, Quaternion.identity); //spawns the water orb out of the end of the gun
            element = false; //switches the ammo type to lightning. 
        }
        else
        {
            Instantiate(lightningOrb, spwnpoint.position, Quaternion.identity); //spawns the lightning orb out of the end of the gun
            element = true; //switches the ammo type to water
        }
        
        
    }

    
    
}
