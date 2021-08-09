using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHitByEnemy : MonoBehaviour
{
    public GameObject GameOverScreen;
    public bool GameOver = false;
    public GameObject LivesScreen;
    public bool Livess = true;
    public GameObject[] livesSprites;
    public int lives = 3;
    public AudioSource HurtPlayer;
    public AudioSource DeathPlayer;
    public AudioSource CoinGrab;
    public GameObject PlayerDeath;
    public bool PlayerDies;
    
    // Start is called before the first frame update
    void Start()
    {
        GameOverScreen.SetActive(false);
        GameOver = false;
        PlayerDeath.SetActive(true);
        LivesScreen.SetActive(true);
        Livess = true;
        PlayerDies = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            HurtPlayer.Play();
            Destroy(livesSprites[lives - 1]);
            lives -= 1;
            if(lives == 0)
            {
                DeathPlayer.Play();
                PlayerDeath.SetActive(false);
                PlayerDies = false;
                GameOverScreen.SetActive(true);
                GameOver = true;
                
            }
        }
        if (collision.gameObject.CompareTag("Ghoul"))
        {
            HurtPlayer.Play();
            if(lives > 1)
            {
                Destroy(livesSprites[lives - 2]);
            }
            Destroy(livesSprites[lives - 1]);
            lives -= 2;
            
            if(lives < 0)
            {
                DeathPlayer.Play();
                PlayerDeath.SetActive(false);
                PlayerDies = false;
                GameOverScreen.SetActive(true);
                GameOver = true;
            }
            if(lives == 0)
            {
                DeathPlayer.Play();
                PlayerDeath.SetActive(false);
                PlayerDies = false;
                GameOverScreen.SetActive(true);
                GameOver = true;
            }

            
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            CoinGrab.Play();
            Destroy(collision.gameObject);
        }
    }
}
