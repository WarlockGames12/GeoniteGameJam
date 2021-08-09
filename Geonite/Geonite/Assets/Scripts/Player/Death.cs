using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject GameOverScreen;
    public bool GameOver;
    public GameObject Player;


    void Start()
    {
        GameOverScreen.SetActive(false);
        GameOver = false;
        Player.SetActive(true);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            GameOverScreen.SetActive(true);
            GameOver = true;
            Player.SetActive(false);
        } 
    }

}
