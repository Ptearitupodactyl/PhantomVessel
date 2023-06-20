using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapRadiusScript : MonoBehaviour
{
    public bool mouseInRadius;

    void OnMouseOver()
    {
        mouseInRadius = true;
        Debug.Log("working");
    }
}
