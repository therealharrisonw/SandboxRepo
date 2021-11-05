using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterOrb : MonoBehaviour
{
    Rigidbody rBody; //targets the rigidbody on the waterorb
    float speed = 5.5f; //float for how fast the orb leaves the gun
    float lifespan = 2.0f; //float for how long the orb stays before despawning 
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>(); //tells the script to get the components off of rigidbody.
        rBody.AddForce(Vector3.forward * speed, ForceMode.VelocityChange); //adds forward force to the orb 
       
    }

    // Update is called once per frame
    void Update()
    {
        if (lifespan >= 0) //if lifespan is more than 0
        {
            lifespan -= Time.deltaTime; //decrease lifespans time
        }
        else //if lifespan is 0 
        {
            Destroy(gameObject); //destroy the water orb
        }
    }
}
