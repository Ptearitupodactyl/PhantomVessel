using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    PlayerOverlord player;
    [SerializeField]
    TMP_Text ammoCountTXT;

    [SerializeField]
    GameObject pauseMenu;
    public static bool paused = false;
    [SerializeField]
    GameObject settingsMenu;
    [SerializeField]
    GameObject keyBindsMenu;
    [SerializeField]
    GameObject stageClear;


    public void Start()
    {
        Time.timeScale = 1f;//Makes sure time is working
    }
    public void Update()
    {
        
        if (player.ammo != 0) //Shows the ammo the player has
        {
            ammoCountTXT.text = player.ammo + "/1";
        }
        else
        {
            ammoCountTXT.text = "";
        }

        if (Input.GetKeyDown(KeyCode.Escape))//Controls pausing
        {
            if (paused)
            {
                UnPause();
            }
            else
            {
                Pause();
            }
            
        }
    }


    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }
    public void UnPause ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }
    public void OpenSettings()
    {
        settingsMenu.SetActive(true);
    }
    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
    }
    public void OpenKeyBinds()
    {
        keyBindsMenu.SetActive(true);
    }
    public void CloseKeyBinds()
    {
        keyBindsMenu.SetActive(false);
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
    public void StageClear ()
    {
        stageClear.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Restart ()//Restarts the game level, *TEST PURPOSES*
    {
        SceneManager.LoadScene(0);
    }
}
