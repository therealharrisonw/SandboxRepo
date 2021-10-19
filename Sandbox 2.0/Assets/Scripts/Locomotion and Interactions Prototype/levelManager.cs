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
        hJoint = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hJoint.angle == hJoint.limits.max)
        {
            bookshelf.SetActive(false); 
        }
    }
}
