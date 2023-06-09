using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverlord : MonoBehaviour
{

    SpriteRenderer spriteRen;
    bool hasGun;

    


    public void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();//Gets sprite renderer
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Weapon" && Input.GetKey("e")) //Detects if the player is over a weapon and detects input
        {
            spriteRen.color = Color.red;
            Destroy(collision.gameObject);
            hasGun = true;
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
               myProjectile = Instantiate(projectile, firePoint.transform.position, Quaternion.identity) as GameObject;//Spawns the bullets
               rb = myProjectile.GetComponent<Rigidbody2D>();
               rb.AddForce(transform.up * forceMagnitude, ForceMode2D.Impulse);//Makes the bullet fly
        }
    }
}
