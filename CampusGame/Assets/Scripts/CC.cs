using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC : MonoBehaviour {

    public float maxSpeed = 10f;
    bool facingRight = true;
    Rigidbody2D rigidbody2d;
	// Use this for initialization
	void Start () {
        rigidbody2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float move = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");
        rigidbody2d.velocity = new Vector2(move * maxSpeed, movey * maxSpeed);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
