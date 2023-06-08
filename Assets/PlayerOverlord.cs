using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverlord : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;

    public GameObject bulletPrefab;

    private void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.white;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Weapon" && Input.GetKey("e"))
        {
            m_SpriteRenderer.color = Color.red;
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, gameObject.transform);
        }
    }
}
