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
    GameObject fireball;
    [SerializeField]
    Transform spwnpoint;
    // Start is called before the first frame update
    void Awake()
    {
        GI = GetComponent<XRGrabInteractable>();
        GI.activated.AddListener(SpawnElements);
    }

    private void SpawnElements(ActivateEventArgs arg0)
    {
        Instantiate(waterOrb, spwnpoint.position, Quaternion.identity);
        Instantiate(lightningOrb, spwnpoint.position, Quaternion.identity);
        Instantiate(fireball, spwnpoint.position, Quaternion.identity);
    }
}
