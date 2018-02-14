using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 10;  
    private float jump = 10f;
    public Transform shootSpwan; // postion for fire
    public GameObject ball;      // reference for ball
    public float FireRat;        // the rat for fire
    private float nexFire;       // next fire 
    Rigidbody2D rb;
    public bool isGrounded;     // checkig if its on floor
    public LayerMask whatISGround; // which layer for floor
    public Transform groundCheck;  
    public float groundCheckRadius;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
   
    // Update is called once per frame
    void Update () {
        //set layer for floor
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatISGround);
       // for jump
       if (Input.GetKeyDown (KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
       // fire
       if (Input.GetButton("Fire1") && Time.time > nexFire)
        {
            nexFire = Time.time + FireRat;
            Instantiate(ball, shootSpwan.position, shootSpwan.rotation);
        }
    }
    private void FixedUpdate()
    {
        //input for movement
        float h = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(h, 0f);
        rb.AddForce(move * speed);
        if (h > 0f)
        {
            transform.localScale = new Vector2(7.683063f, 8.631892f);
        }
        else if (h < 0f)
        {
            transform.localScale = new Vector2(-7.683063f, 8.631892f);
        }
    }
    
}
