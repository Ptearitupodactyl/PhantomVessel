using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    SpriteRenderer spriteRen;
    public bool hasGun;
    public string gunType;
    public int ammo = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Weapon" && Input.GetKey("e")) //Detects if the player is over a weapon and detects input
        {
            RangedAssign weapon = collision.gameObject.GetComponent<RangedAssign>();
            hasGun = true;
            ammo += weapon.ammo;
            spriteRen.color = weapon.color;
            gunType = weapon.weaponName;
            Destroy(collision.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

}
