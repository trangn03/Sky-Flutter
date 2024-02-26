using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicStartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void playGame()
    {
        SceneManager.LoadScene("Game Play");
    }
    public void instructionsGame()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
