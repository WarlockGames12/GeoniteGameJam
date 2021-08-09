using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public bool Mission = false;
    public GameObject MissionUI;
    public int CoinsOpenDoor = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        Mission = false;
        MissionUI.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collided)
    {
        if (collided.gameObject.CompareTag("Coin"))
        {
            CoinsOpenDoor -= 1;

        }
    }

    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            MissionUI.SetActive(true);
        }
        if (CoinsOpenDoor == 0)
        {
            if (collision.gameObject.CompareTag("Door"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

   

    void OnTriggerExit2D(Collider2D other)
    {
        MissionUI.SetActive(false);
    }
}
