using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverlord : MonoBehaviour
{

    SpriteRenderer spriteRen;

    public GameObject firePoint;
    public GameObject bulletPrefab;

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

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, firePoint.transform);
        }
    }
}
