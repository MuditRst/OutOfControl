using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject weapon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentWeapon();
    }

    public void CurrentWeapon(){
        weapon = null;
    }
}
