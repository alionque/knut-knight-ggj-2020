using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnutKnightController : MonoBehaviour
{
    public float speed;             
    private Rigidbody2D rb2d;
    public Vector2 jumpHeight;
    public GameObject bottom;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {

        if (isGrounded() && Input.GetButtonDown("Jump")) //makes player jump
        {
            jumpHeight.x = rb2d.velocity.x;
            rb2d.velocity = (jumpHeight);
        }

      
    }
    bool isGrounded() {

        int layerMask = 1 << 8;
      
        return Physics2D.Raycast(bottom.transform.position, Vector2.down, 0.5f ,layerMask);
    }


    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal * speed , rb2d.velocity.y);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.velocity = (movement);


    }


     
}
