using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    private int goalieScore;
    private int playerScore;
    public Text playerT;
    public Text goalieT;
    public Text winText;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerScore = goalieScore = 0;
        playerT.text ="Player Score: " + playerScore.ToString();
        goalieT.text = "Goalie Score: "+ goalieScore.ToString();
        winText.text = "";
        
}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "goal")
        {
            playerScore++;
            playerT.text = "Player Score: " + playerScore.ToString();
            resetPosition();
            if (playerScore == 5)
            {
                winText.text = "You have won!";
                endGame();
            }
        }
        else if (col.gameObject.tag == "goalie")
        {
            goalieScore++;
            goalieT.text = "Goalie Score: " + goalieScore.ToString();
            resetPosition();
            if (goalieScore == 5)
            {
                winText.text = "You have lost!";
                endGame();
                
            }
        }
        else if (col.gameObject.tag == "outOfBounds")
        {
            resetPosition(); 
        }
 
    }

    void resetPosition()
    {
     transform.position = new Vector3(0, 0.5f, -8);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void endGame()
    {
        Application.Quit();

    }
}
