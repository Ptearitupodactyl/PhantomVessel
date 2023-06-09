using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float delay = 5f;
    public int damage = 1;

    private void Start()
    {
        StartCoroutine(DestroyAfterTime());
         
    }


    void OnTriggerEnter2D(Collider2D other) //Checks to see if it is colliding with an object
    {
        if (other.gameObject.tag == "Enemy") //Checks to see if it is colliding with anything tagged as an enemy
        {
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage); //Pulls the EnemyHealth script and calls the TakeDamage method with a of "damage" which can be changed on the bullet prefab
        }
        Destroy(gameObject); //Since the bullet will most likely need to be deleted anytime it hits an object the bullet is destroyed when it collides with anything.
    }
    IEnumerator DestroyAfterTime() //Gives a timer for the game object to be destroyed if it doesn't hit an object. 
    {
        yield return new WaitForSeconds(delay); 
        Destroy(gameObject);
    }
}
