using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatFunc : MonoBehaviour
{
    float yPos;
    [SerializeField]
    [Range(0, 5)]
    private float yRange;
    [SerializeField]
    float floatSpeed;

    // Update is called once per frame
    void Update()
    {
        yPos = Mathf.PingPong(Time.time * floatSpeed, 1) * yRange;
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
}
