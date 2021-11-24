using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverDetection : MonoBehaviour
{
    [SerializeField]
    private UnityEvent levergang;
     HingeJoint hJoint;
    bool lever1 = false;
    bool lever2 = false;
    bool lever3 = false;
    bool lever4 = false;
    [SerializeField]
    private UnityEvent finalDoor;

    private void Start()
    {
        hJoint = GetComponent<HingeJoint>(); //teels the hinge joint to take that information
        
    }

    private void Update()
    {
        if (hJoint.angle == hJoint.limits.min)
        {
            
            levergang.Invoke();
            Debug.Log("Testing");
        }

        if (lever1 == true && lever2 == true && lever3 == true && lever4 == true)
        {
            finalDoor.Invoke();
        }
    }

    

}

