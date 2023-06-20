using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject projectile;
    public GameObject sgProjectile;
    GameObject myProjectile;
    Rigidbody2D rb;
    float forceMagnitude = 10;
    SpriteRenderer spriteRen;

    // Start is called before the first frame update
    void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        WeaponPickup wPickup = GetComponent<WeaponPickup>();
        if (Input.GetMouseButtonDown(0) && wPickup.hasGun)
        {
            Shoot(wPickup);
            wPickup.ammo -= 1; 
        }
        if(wPickup.ammo < 1)
        {
            wPickup.hasGun = false;
            spriteRen.color = Color.white;
        }

    }


    public void Shoot(WeaponPickup weapon)
    {

        if (weapon.gunType == "Pistol")
        {
            myProjectile = Instantiate(projectile, firePoint.transform.position, Quaternion.identity) as GameObject;//Spawns the bullets
            rb = myProjectile.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * forceMagnitude, ForceMode2D.Impulse);
  
        }

        if (weapon.gunType == "Shotgun")
        {
            myProjectile = Instantiate(sgProjectile, firePoint.transform.position, firePoint.transform.rotation) as GameObject;
        }
    }

}