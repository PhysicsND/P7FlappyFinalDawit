using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject gameOverText;
    public bool gameOver = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    void Update()
    {
        // optional: restart on click
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex
            );
        }
    }
}
