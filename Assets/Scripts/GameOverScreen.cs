using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public bool isPlayer = true;

    void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Animals"))
       {
       if (isPlayer == true)
       {
       Debug.Log("Game Over");
       }

       }
       
       Destroy(gameObject);
       Destroy(other.gameObject); 
       
    }
    // if an animal collides with the player it will destory the animal and the player and give a game over screen
}

