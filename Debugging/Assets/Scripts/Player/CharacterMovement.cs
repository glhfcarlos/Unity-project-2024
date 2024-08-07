using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private NPC_Controller npc;
   
    public float moveSpeed = 1000;

    public Rigidbody2D rb;
    
    Vector2 movement; 
    
    private void Update()
    {
        if (!inDialogue())
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            
            // Normalize the movement vector to prevent faster diagonal movement
            movement.Normalize();
        }
        else
        {
            // Reset movement when in dialogue
            movement = Vector2.zero;
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
        if (collision.gameObject.CompareTag("NPC"))
        {
            npc = collision.gameObject.GetComponent<NPC_Controller>();

            if (Input.GetKeyDown(KeyCode.E))
                npc.ActivateDialogue();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            npc = null;
        }
    }
}
