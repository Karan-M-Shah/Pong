using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Scored : MonoBehaviour {
    public int Player1Score;
    public Text Player1ScoreText;
    // Use this for initialization
    void Start () {
        SetScoreText();
        Player1Score = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Player1Score++;
            SetScoreText();
            GameObject.FindGameObjectWithTag("Ball").GetComponent<BallMovement>().RestartGame();
        }
    }

    void SetScoreText()
    {
        Player1ScoreText.text = "Player 1 Score: " + Player1Score.ToString();
    }
}
