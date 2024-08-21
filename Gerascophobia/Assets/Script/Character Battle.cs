using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBattle : MonoBehaviour 
{

    private PlayerMovement playermovement;

   private void Awake () 
   {
        playermovement = GetComponent<PlayerMovement>();
   }


    private void Start() 
    {
        playermovement.transform.Translate(new Vector3(1, 0, 0));
    }

} 