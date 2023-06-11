using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOverlord : MonoBehaviour
{
    [SerializeField]
    UIManager UI_;
    [SerializeField]
    int enemieCount;


    // Update is called once per frame
    void Update()
    {
        enemieCount = GameObject.FindGameObjectsWithTag("Enemy").Length; //Counts how many enemies are in scene
        if (enemieCount <= 0)//Tells the UIManager the stage is clear
        {
            UI_.StageClear();
        }
    }
}
