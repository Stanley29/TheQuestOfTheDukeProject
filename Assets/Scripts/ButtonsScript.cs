using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject deathPanel;
    //public Text pauseText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PauseInGameGame();
        }
    }

    void PauseInGameGame()
    {
        Time.timeScale = 0;
        //Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.None;
        pausePanel.SetActive(true);
    }

    public void ResumePauseInGameGame()
    {
        Time.timeScale = 1;
        //Cursor.visible = false;  //collected items list initiate
        //Cursor.lockState = CursorLockMode.Locked;
        pausePanel.SetActive(false);
    }

    public void MainMenu()
    {
        //Application.Quit();
        Time.timeScale = 1;
        deathPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
