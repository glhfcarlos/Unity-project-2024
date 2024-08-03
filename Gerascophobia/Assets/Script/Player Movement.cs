using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private NPC_Controller npc;
   
    public float moveSpeed = 5;

    public Rigidbody2D rb;
    public Animator animator;

    public VectorValue startingPosition;
    
    Vector2 movement;
    
    void Start ()
    {
        GameData.has_sword = true; 

        transform.position = startingPosition.initalValue;
    }



    private void Update()
    {
        if (!inDialogue())
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
        if (movement.x != 0  || movement.y != 0){
                    
                    animator.SetFloat("Horizontal", movement.x);
                    animator.SetFloat("Vertical", movement.y);

                    animator.SetBool("IsWalking", true);
                    } else{
                        animator.SetBool("IsWalking", false);
                    }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    
        private bool inDialogue()
    {
        if (npc != null)
            return npc.DialogueActive();
        else
            return false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            npc = collision.gameObject.GetComponent<NPC_Controller>();

            if (Input.GetKey(KeyCode.E))
                npc.ActivateDialogue();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        npc = null;
    }

}
