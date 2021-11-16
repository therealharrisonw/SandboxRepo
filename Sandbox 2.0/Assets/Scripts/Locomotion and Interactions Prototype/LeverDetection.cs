using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverDetection : MonoBehaviour
{
    [SerializeField]
    private UnityEvent levergang;
     HingeJoint hJoint;

    private void Start()
    {
        hJoint = GetComponent<HingeJoint>(); //teels the hinge joint to take that information
        
    }

    private void Update()
    {
        if (hJoint.angle == hJoint.limits.min)
        {
            Debug.Log("Do you work?");
            levergang.Invoke();
        }
    }

}

