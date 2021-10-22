using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZapManager : MonoBehaviour
{
    [SerializeField]
    GameObject staircase; //used to select what object is the staircase

    private void OnTriggerEnter(Collider other) //when an object enters the trigger 
    {
        if(other.gameObject.tag == "ZapOrb") //if the other object that collides has the tag zapOrb do this
        {
            staircase.SetActive(true); //sets the staircase to appear. 
        }
    }


}
