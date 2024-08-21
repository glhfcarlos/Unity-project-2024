using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battlehandler : MonoBehaviour
{
    [SerializeField] private GameObject pfCharacterBattle;

    private void Start () {
        if (pfCharacterBattle == null) {
            Debug.LogError("pfCharacterBattle is not assigned in the inspector. Please assign it to the Battlehandler script.");
            return;
        }
        SpawnCharacter(true);
        SpawnCharacter(false);
    }

    private void SpawnCharacter (bool isPlayerteam) {
        Vector3 position;
        if (isPlayerteam) {
            position = new Vector3(-50,0);
        } else {
            position = new Vector3(+50,0);
        }
        Instantiate(pfCharacterBattle, position, Quaternion.identity);
    }
}
