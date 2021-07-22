using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.gameObject.tag == "MyCoin")
        {
            Debug.Log("CoinTest");
            if (currentHealth == 3)
            {
                Debug.Log("test1");
                currentHealth--;
                heart1.SetActive(false);
                return;
            }

            if (currentHealth == 2)
            {
                Debug.Log("test2");
                currentHealth--;
                heart2.SetActive(false);
                return;
            }

            if (currentHealth == 1)
            {
                Debug.Log("test3");
                heart3.SetActive(false);
                currentHealth = 3;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            }
        }

        
    }
}