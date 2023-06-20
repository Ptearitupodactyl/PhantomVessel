using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SwapAbility : MonoBehaviour
{
    public GameObject swapItem;
    public GameObject swapRadiusObj;
    public bool inRadius;

    int layerMask;


    private void Start()
    {
        layerMask = LayerMask.GetMask("Default");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SwapItem")
        {
            inRadius = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SwapItem")
        {
            inRadius = false;
        }   
    }
    void Update () 
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero, 1000, layerMask);            
            if (hit.collider != null && hit.collider.gameObject.tag == "SwapItem" && inRadius == true) 
            {
                Debug.Log(hit.collider.gameObject.name);
                swapItem = hit.collider.gameObject;
                Swap();
            }
        }
    }

    

    void Swap()
    {
        Vector3 temp = transform.position;
        transform.position = swapItem.transform.position;
        swapItem.transform.position = temp;
    }

}
