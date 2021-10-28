using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class bubbleshoot : MonoBehaviour
{
    XRGrabInteractable GI;
    [SerializeField]
    GameObject bubblePrefab;
    [SerializeField]
    Transform spwnpoint;
    private int ammo = 10;
    [SerializeField]
    private TextMeshProUGUI ammotext;
    // Start is called before the first frame update
    void Awake()
    {
        GI = GetComponent<XRGrabInteractable>();
        GI.activated.AddListener(SpawnBubbles);
    }

    private void SpawnBubbles(ActivateEventArgs arg0)
    {
        if (ammo > 0)
        {
            Instantiate(bubblePrefab, spwnpoint.position, Quaternion.identity);
            ammo--;
            ammotext.text = ammo.ToString();
        }
    }

    
   
}
