using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpiritShot : MonoBehaviour
{
    public GameObject swapItem;
    void Update () {
        if (Input.GetMouseButtonDown(1)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject.tag == "SwapItem") {
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
