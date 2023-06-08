using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb; 

    float horizontal;
    float vertical;

    public float runSpeed = 20f;

    void Start()
    {   //Gets the RigidBody component from our player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   //Gets the input
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {   //Applies input and speed
        rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        Vector3 ObjPos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - ObjPos;
        float rotZ = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;

        rb.MoveRotation(-rotZ);
    }
}
