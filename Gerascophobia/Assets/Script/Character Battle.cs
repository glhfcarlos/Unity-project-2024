using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBattle : MonoBehaviour {
   private PlayerMovement playermovement;

   private void Awake () {
    playermovement = GetComponent<PlayerMovement>();
   }
    private void Update() {
        playermovement.movement.x = 1f;
        playermovement.animator.SetFloat("Horizontal", playermovement.movement.x);
        playermovement.animator.SetBool("IsWalking", true);
    }
}
