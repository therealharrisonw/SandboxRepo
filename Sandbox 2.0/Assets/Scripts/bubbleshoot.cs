using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
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
    [SerializeField]
    InputActionReference reloadAction;
    XRBaseInteractor interactor;
    ActionBasedController actionController;
    // Start is called before the first frame update
    void Awake()
    {
        GI = GetComponent<XRGrabInteractable>();
        GI.activated.AddListener(SpawnBubbles);
        reloadAction.action.started += Reload;
    }

    public void GetInteractor()
    {
        interactor = GI.selectingInteractor;
    }
    public void releaseInteractor()
    {
        interactor = null;
    }
    private void Reload(InputAction.CallbackContext obj)
    {
       if(obj.control.ToString().Contains("Left") && interactor.name.Contains("Left"))
        {
            ammo = 10;
            ammotext.text = ammo.ToString();
        }
        else if (obj.control.ToString().Contains("Right") && interactor.name.Contains("Right"))
        {
            ammo = 10;
            ammotext.text = ammo.ToString();
        }
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
