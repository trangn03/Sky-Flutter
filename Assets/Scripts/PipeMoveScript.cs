// Script obtained from Game Maker's Toolkit
// https://youtu.be/XtQMytORBmM?si=B7xiQyCWHa_6jaqU

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        // I added this condition to stop the pipes from moving when the game is over
        if (!logic.isGameActive) {
            return;
        
        }

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted!");
            Destroy(gameObject);
        }
    }
}
