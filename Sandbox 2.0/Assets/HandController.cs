using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine;
using System;

public class HandController : MonoBehaviour
{
    [SerializeField]
    GameObject baseControllerObject;
    [SerializeField]
    GameObject teleportGameObject;
    [SerializeField]
    InputActionReference teleportActivationRefrence;

    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;
    // Start is called before the first frame update
    void Start()
    {
        teleportActivationRefrence.action.performed += teleportModeActivate;
        teleportActivationRefrence.action.canceled += teleportModeCancel;
    }

    private void teleportModeCancel(InputAction.CallbackContext obj)
    {
        Invoke("DeactivateTeleporter", 0.1f);
    }

    void DeactivateTeleporter()
    {
        onTeleportCancel.Invoke();
    }

    private void teleportModeActivate(InputAction.CallbackContext obj)
    {
        onTeleportActivate.Invoke();
    }
}
