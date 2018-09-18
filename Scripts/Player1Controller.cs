using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{

    public float topboundary = 4.6f;
    public float bottomboundary = -4.6f;
    public float playerspeed = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player1 = GameObject.FindGameObjectWithTag("Player1");

        if (Input.GetKey("w") && Player1.transform.position.y < topboundary)
        {
            transform.Translate(0, playerspeed * Time.deltaTime, 0);
        }


        if (Input.GetKey("s") && Player1.transform.position.y > bottomboundary)
        {
            transform.Translate(0, -1 * playerspeed * Time.deltaTime, 0);
        }
    } 
}
