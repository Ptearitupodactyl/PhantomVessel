using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAssign : MonoBehaviour
{
    public Weapon weapon;

    public string weaponName;
    public int ammoCount;
    // Start is called before the first frame update
    void Start()
    {
        weaponName = weapon.weaponName;
        ammoCount = weapon.ammoValue;
    }


}
