using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teleManager : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject teleportMarker;
    // Start is called before the first frame update
    public void tele()
    {
        Player.transform.position = teleportMarker.transform.position;
    }

    
}
