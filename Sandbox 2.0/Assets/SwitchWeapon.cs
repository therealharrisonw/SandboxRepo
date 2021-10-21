
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchWeapon : MonoBehaviour
{
    public InputActionReference SwitchWeapons = null;
    public int selectedWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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

            if (i == 3)
            {
                i = 0;
            }
        }
    }

    // Update is called once per frame
    void OnSwitchWeapons()
    {
        Debug.Log("Switched");
        
    }
}
