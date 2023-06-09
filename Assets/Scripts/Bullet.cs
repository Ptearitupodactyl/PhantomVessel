using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating("DestroyAfterTime", 15f, 60f);//Starts a timer that destroys the bullet after a certain amount time
    }


    private void OnTriggerEnter2D(Collider2D collision)//Checks what the bullets hits
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
    void DestroyAfterTime()
    {
        Destroy(gameObject);
    }
}
