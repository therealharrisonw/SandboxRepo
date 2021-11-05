using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    Rigidbody rBody; //targets the rigidbody on the lightning or zap orb.
    float speed = 10.0f; //float for how fast the orb leaves the gun
    float lifespan = 0.5f; //float for how long the orb stays before despawning 

    void Start()
    {
        rBody = GetComponent<Rigidbody>(); //tells the script to get the components off of rigidbody.
        rBody.AddForce(Vector3.forward * speed, ForceMode.VelocityChange); //adds forward force to the orb 

    }
    
    void Update()
    {
        if (lifespan >= 0) //if lifespan is more than 0
        {
            lifespan -= Time.deltaTime; //decrease lifespans time
        }
        else //if lifespan is 0 
        {
            Destroy(gameObject); //destroy the lightning orb
        }
    }
}
