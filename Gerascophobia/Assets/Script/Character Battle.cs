using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBattle : MonoBehaviour {
   private PlayerMovement playermovement;

   private void Awake () {
    playermovement = GetComponent<PlayerMovement>();
   }
    private void Update() {
        playermovement.movement = new Vector2(0.25f,0);
    }
} 