using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
       Destroy(gameObject);
       Destroy(other.gameObject); 
    }
    // if an animal collides with the player it will destory the animal and the player and give a game over screen
}

