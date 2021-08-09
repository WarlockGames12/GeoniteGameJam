using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool Pause;
    public GameObject pauseMenu;
    public AudioSource PauseSound;


    // Start is called before the first frame update
    void Start()
    {
        Pause = false;
        pauseMenu.SetActive(false);
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Pause == true)
        {
            PauseSound.Play();
            Resume();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && Pause == false)
        {
            PauseSound.Play();
            GamePause();
        }
    }

    void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Pause = false;
    }

    void GamePause()
    {
        pauseMenu.SetActive(true); //set the pause menu ui on false
        Time.timeScale = 0f; //Za Warudo
        Pause = true; //Gameobject is put on true
    }
}
