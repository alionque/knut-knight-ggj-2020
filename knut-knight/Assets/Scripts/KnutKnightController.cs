using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnutKnightController : MonoBehaviour
{
    public Animator anim;
    public float speed;             
    private Rigidbody2D rb2d;
    public Vector2 jumpHeight;
    public GameObject bottom;
    private bool dead = false;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if(dead) {
            return;
        }

        if (isGrounded() && Input.GetButtonDown("Jump")) //makes player jump
        {
            anim.SetTrigger("jump");
            jumpHeight.x = rb2d.velocity.x;
            rb2d.velocity = (jumpHeight);
        }

      
    }
    bool isGrounded() {

        int layerMask = 1 << 8;
      
        return Physics2D.Raycast(bottom.transform.position, Vector2.down, 0.5f ,layerMask);
    }

    public void died() {
        dead = true;
        anim.SetTrigger("die");
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("KnutHori");

        if(moveHorizontal < 0) {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        } else {
            transform.rotation = Quaternion.identity;
        }
        anim.SetFloat("vel", Mathf.Abs(moveHorizontal));
        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal * speed , rb2d.velocity.y);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.velocity = (movement);


    }


     
}
