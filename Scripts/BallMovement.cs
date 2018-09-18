using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    public float ballspeed = 15f;
    Rigidbody2D rb;
    // Use this for initialization
    void Start () {
    rb = GetComponent<Rigidbody2D>();
        Invoke("BallSpawn", 1);
        // Add a force to the Rigidbody.
    }
	
	// Update is called once per frame
	void Update () {
 

    }

    void BallSpawn()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb.AddForce(new Vector2(20, -10)* ballspeed);
        }
        else
        {
            rb.AddForce(new Vector2(-20, -10)* ballspeed); 
        }
    }

    //Resets ball's position back to original starting point (0,0). 
    void ResetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke("BallSpawn", 1);
    }

    public void RestartGame()
    {
        Invoke("ResetBall", 3);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rb.velocity = vel;
            Debug.Log(+vel.y+"is the balls y velocity");
        }
    }


} 
