
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchWeapon : MonoBehaviour
{
    public int selectedWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        Selectweapon();
    }

    private void Selectweapon()
    {
        int i = 0;
       foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
