using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyBinds : MonoBehaviour
{
    public Dictionary<string, KeyCode> keyBinds = new Dictionary<string, KeyCode>();

    public TMP_Text up, left, down, right, shoot;

    private GameObject currentKey;

    void Start()
    {
        keyBinds.Add("Up", KeyCode.W);
        keyBinds.Add("Down", KeyCode.S);
        keyBinds.Add("Left", KeyCode.A);
        keyBinds.Add("Right", KeyCode.D);
        keyBinds.Add("Shoot", KeyCode.Mouse0);

        up.text = keyBinds["Up"].ToString();
        down.text = keyBinds["Down"].ToString();
        left.text = keyBinds["Left"].ToString();
        right.text = keyBinds["Right"].ToString();
        shoot.text = keyBinds["Shoot"].ToString();
    }


    private void OnGUI()
    {
        if (currentKey != null)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                keyBinds[currentKey.name] = e.keyCode;
                currentKey.transform.GetChild(0).GetComponent<TMP_Text>().text = e.keyCode.ToString();
                currentKey = null;
            }
        }
    }

    public void ChangeKey (GameObject clicked)
    {
        currentKey = clicked;
        Debug.Log(clicked.ToString());
    }
}
