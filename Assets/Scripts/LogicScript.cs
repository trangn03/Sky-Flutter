// Script obtained from Game Maker's Toolkit
// https://youtu.be/XtQMytORBmM?si=B7xiQyCWHa_6jaqU

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource addScoreSound;
    public bool isGameActive = true;

    // I added sound to this function
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        addScoreSound.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // I modify this function to stop the pipes from spawning and moving when the game is over
    public void gameOver()
    {
        isGameActive = false;
        gameOverScreen.SetActive(true);
    }

    // I added this function to restart the game
    public void quitGame()
    {
        Application.Quit();
    }
}
