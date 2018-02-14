using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    Rigidbody2D EnemyRb;
    public float moveSpeed;
    public bool moveright;
    public Transform wallCheck; //reference for checking postion 
    public float WallCheckRadius; // how much Radius
    public LayerMask whatiswall; // which layer collided
    private bool hittingWall;  // get checked if collided
	// Use this for initialization
	void Start () {
        EnemyRb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //set which layer is collided
        hittingWall = Physics2D.OverlapCircle(wallCheck.position, WallCheckRadius, whatiswall);
        if (hittingWall)
        {
            moveright = !moveright;
        }
        //move enemy after collided
        if (moveright)
        {
            transform.localScale = new Vector3(-4.422059f, 4.422059f, 4.422059f);
            EnemyRb.velocity = new Vector2(moveSpeed, EnemyRb.velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(4.422059f, 4.422059f, 4.422059f);
            EnemyRb.velocity = new Vector2(-moveSpeed, EnemyRb.velocity.y);
        }
        // later they stoped to move ?????
	}
    
}
