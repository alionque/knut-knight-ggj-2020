using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    private static bool canMove = false;
    public static void START_THE_DRAGON() {
        canMove = true;
    }

    public Animator anim;
    public float spd = 3f;

    // Start is called before the first frame update
    void Start()
    {
        canMove = false; //On each level or dragon spawn pause said dragon.
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("moving", canMove);
    
        if (canMove) {
            transform.position += Vector3.right * spd * Time.deltaTime; //This will only move right and when things collide with it it will then react to those things.
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag.Equals("Player")) {
            collision.gameObject.GetComponent<KnutKnightController>().died();
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(!collision.tag.Equals("Player")) {
            Destroy(collision.gameObject); // BLOW UP DA WORLD
        }
    }
}
