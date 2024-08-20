using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battlehandler : MonoBehaviour
{
    [SerializeField] private Transform pfCharacterBattle;

    private void Start () {
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
