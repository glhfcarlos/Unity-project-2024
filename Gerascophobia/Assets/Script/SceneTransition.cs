using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string SceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;

    public void OnTriggerEnter2D(Collider2D Player)
    {
        if(Player.CompareTag("Player")  &&  !Player.isTrigger)
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
