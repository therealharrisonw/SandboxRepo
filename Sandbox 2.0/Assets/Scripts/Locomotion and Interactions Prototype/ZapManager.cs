using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZapManager : MonoBehaviour
{
    [SerializeField]
    GameObject staircase;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ZapOrb")
        {
            staircase.SetActive(true);
        }
    }


}
