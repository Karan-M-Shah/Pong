using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {
    public float topboundary = 4.6f;
    public float bottomboundary = -4.6f;
    public float playerspeed = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject Player2 = GameObject.FindGameObjectWithTag("Player2");

        if (Input.GetKey(KeyCode.UpArrow) && Player2.transform.position.y < topboundary)
        {
            transform.Translate(0, playerspeed * Time.deltaTime, 0);
        }


        if (Input.GetKey(KeyCode.DownArrow) && Player2.transform.position.y > bottomboundary)
        {
            transform.Translate(0, -1 * playerspeed * Time.deltaTime, 0);
        }
    }
} 

