using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    HingeJoint hJoint; //calls the Hinge Joint off of the lever gameobject 
    [SerializeField]
    GameObject bookshelf;
    // Start is called before the first frame update
    void Start()
    {
        hJoint = GetComponent<HingeJoint>(); //teels the hinge joint to take that information
    }

    // Update is called once per frame
    void Update()
    {
        if (hJoint.angle == hJoint.limits.max) //if my hinge joint is set to maximum
        {
            bookshelf.SetActive(false); //hide the bookshelf and access the next area. 
        }
    }
}
