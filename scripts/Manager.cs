using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Manager : MonoBehaviour
{
    public int score;

    public Text scoreText;
    void Start()
    {
        
    }

    
    void Update()
    {
        gameScore();
    }

    private void gameScore()
    {
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
