using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicInstructionsScript : MonoBehaviour
{
    public void returnToStart()
    {
        SceneManager.LoadScene("Begin Play");
    }
}
