using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float offScreenThreshold = -6.5f; // Threshold for off-screen detection

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birdIsAlive)
        {
            if ((Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.UpArrow)))
            {
                myRigidbody.velocity = Vector2.up * flapStrength;
            }

            if (transform.position.y < offScreenThreshold)
            {
                logic.gameOver();
                birdIsAlive = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
