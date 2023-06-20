using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAssign : MonoBehaviour
{
    public RangedWeapon weapon;

    public string weaponName;
    public int ammo;
    public int damage;
    public Color color;
    
    void Start()
    {
        weaponName = weapon.weaponName;
        ammo = weapon.ammo;
        damage = weapon.damage;
        color = weapon.color;   
    }


}
