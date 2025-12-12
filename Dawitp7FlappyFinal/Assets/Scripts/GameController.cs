using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;                 // <-- TextMeshPro namespace
using UnityEngine.UI;        // <-- Only needed if you also use UI images/buttons/etc.

public class GameControl : MonoBehaviour
{
    public static GameControl instance;

    public GameObject gameOverText;
    public TMP_Text scoreText;      // <-- TMP version

    public bool gameOver = false;
    public float scrollSSpeed = -1.5f;

    private int score = 0;

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

    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (gameOver)
            return;

        score++;
        scoreText.text = "Score: " + score;
    }

    public void BirdDied()
    {
        gameOver = true;
        gameOverText.SetActive(true);
    }
}

