using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterManager : MonoBehaviour
{
    [SerializeField]
    GameObject ground;//used to select what object is the ground
   
    private void OnTriggerEnter(Collider other) //when an object enters the trigger 
    {
        if (other.gameObject.tag == "WaterOrb") //if the other object that collides has the tag water orb do this
        {
            ground.SetActive(true); //sets the ground to appear. 
        }
    }
}
