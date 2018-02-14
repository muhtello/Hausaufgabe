using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour {
    public float speedBall; // speed movement
    private float timeout = 1f; // set the time to Destroy the ball
    Rigidbody2D BallRb;
    private float h; // input for movement
	// Use this for initialization
	void Start () {
        // destroy ball after seted time
        Destroy(gameObject, timeout);
        BallRb = GetComponent<Rigidbody2D>();
        //playerMove = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        //BallRb.velocity = transform.right * speedBall;   
        h = Input.GetAxis("Horizontal");
        // I tried all kind of movement of ball and all of them moved good
        if (h >= -0)
        {
           // BallRb.AddForce (transform.right * speedBall);
           //BallRb.velocity = transform.right * speedBall;
            transform.Translate(1f * speedBall, 0f, 0f);
            
        }
        else if (h <= 0)
        {
            // BallRb.AddForce(transform.Translate(0,0,1) , ForceMode2D.Impulse);
            //BallRb.AddForce(-transform.right * speedBall);
            transform.Translate(1f * -speedBall, 0f, 0f);
        }
    }
    private void FixedUpdate()
    {
       
    }

}
