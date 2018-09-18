using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Player2Scored : MonoBehaviour {
    public int Player2Score;
    public Text Player2ScoreText;  
    // Use this for initialization
    void Start () {
        SetScoreText();
        Player2Score = 0;
    }
	
	// Update is called once per frame
	void Update () {
       
	}
    //When the ball enters the boxcollider2d trigger the score is updated.
    //The ball also resets to its original position of (0,0) and 
    //references the ballmovement script. 
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Player2Score++;
            SetScoreText();
            //Accesses RestartGame function from ballmovement script.
            GameObject.FindGameObjectWithTag("Ball").GetComponent<BallMovement>().RestartGame();
        }
    }

    void SetScoreText()
    {
        Player2ScoreText.text = "Player 2 Score: " + Player2Score.ToString(); 
    }
}