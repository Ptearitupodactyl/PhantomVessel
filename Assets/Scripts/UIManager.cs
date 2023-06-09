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
    GameObject stageClear;


    public void Start()
    {
        Time.timeScale = 1f;
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


    public void Pause()//Pauses time brings up the menu
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }
    public void UnPause ()//Unpauses
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }
    public void QuitGame ()//<<
    {
        Application.Quit();
    }
    public void StageClear ()//Shows up when the stage clear of all enemies
    {
        stageClear.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Restart ()//Restarts the game level, *TEST PURPOSES*
    {
        SceneManager.LoadScene(0);
    }
}
