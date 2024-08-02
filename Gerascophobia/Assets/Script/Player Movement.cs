using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
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



    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
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

}
