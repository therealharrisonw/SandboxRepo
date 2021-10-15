using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    HingeJoint hj;
    [SerializeField]
    GameObject bubbleGun;
    // Start is called before the first frame update
    void Start()
    {
        hj = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hj.angle == hj.limits.min)
        {
            bubbleGun.SetActive(true);
        }
    }
}
