using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float delay = 5f;


    
    private void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }
    private void OnTriggerEnter2D(Collider2D collision)//Checks what the bullets hits
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
