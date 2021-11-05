using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    private float regulartime = 120;
    [SerializeField]
    private TextMeshProUGUI timetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(regulartime > 0)
        {
            regulartime -= 1 * Time.deltaTime;
            timetext.text = regulartime.ToString();
        }
    }
}
