using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverlord : MonoBehaviour
{

    SpriteRenderer spriteRen;

    


    public void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Weapon" && Input.GetKey("e")) //Detects if the player is over a weapon and detects input
        {
            spriteRen.color = Color.red;
            Destroy(collision.gameObject);
        }
    }

    public GameObject firePoint;
    public GameObject projectile;
    GameObject myProjectile;
    Rigidbody2D rb;
    float forceMagnitude = 5;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
               myProjectile = Instantiate(projectile, firePoint.transform.position, Quaternion.identity) as GameObject;
               rb = myProjectile.GetComponent<Rigidbody2D>();
               rb.AddForce(transform.up * forceMagnitude, ForceMode2D.Impulse);
        }
    }
}
