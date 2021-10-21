using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterOrb : MonoBehaviour
{
    Rigidbody rBody;
    float speed = 0.5f;
    float lifespan = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        rBody.AddForce(Vector3.forward * (speed / 2), ForceMode.VelocityChange);
        rBody.AddForce(Vector3.down * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (lifespan >= 0)
        {
            lifespan -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}