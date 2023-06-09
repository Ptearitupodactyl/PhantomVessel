using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverlord : MonoBehaviour
{

    SpriteRenderer spriteRen;
    bool hasGun;

    float ammo;
    string heldGun;


    public void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();//Gets sprite renderer
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Weapon" && Input.GetKey("e")) //Detects if the player is over a weapon and detects input
        {
            WeaponAssign weapon = collision.gameObject.GetComponent<WeaponAssign>();
            if (weapon.weaponName == "Shotgun")
            {
                spriteRen.color = Color.red;
                Destroy(collision.gameObject);
                hasGun = true;
                heldGun = "ShotGun";
                ammo = 1f;
            }
            if (weapon.weaponName == "Pistol")
            {
                spriteRen.color = Color.blue;
                Destroy(collision.gameObject);
                hasGun = true;
                heldGun = "Pistol";
                ammo = 1f;
            }
            
        }
    }

    public GameObject firePoint;
    public GameObject projectile;
    GameObject myProjectile;
    Rigidbody2D rb;
    float forceMagnitude = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && hasGun == true) //Shoots gun if the player has one
        {
            if (heldGun == "ShotGun")
            {
                myProjectile = Instantiate(projectile, firePoint.transform.position, Quaternion.identity) as GameObject;//Spawns the bullets
                rb = myProjectile.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * forceMagnitude, ForceMode2D.Impulse);//Makes the bullet fly
                ammo -= 1f;
            }
            if (heldGun == "Pistol")
            {
                myProjectile = Instantiate(projectile, firePoint.transform.position, Quaternion.identity) as GameObject;//Spawns the bullets
                rb = myProjectile.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * forceMagnitude, ForceMode2D.Impulse);//Makes the bullet fly
                ammo -= 1f;
            }
            
        }

        if (ammo <= 0f)
        {
            spriteRen.color = Color.white;
            hasGun = false;
        }
    }
}
