using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Ranged Weapon", menuName = "Ranged")]
public class RangedWeapon : ScriptableObject
{
    public string weaponName;

    public int ammo;
    public int damage;
    public Color color; 

    
}
