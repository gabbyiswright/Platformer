using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*****************
 * By Michael Donovan
******************/

//Turns an object into a "boost pad", which launches the player at a specified velocity and direction.
public class BoostPad : MonoBehaviour
{
    private Collider2D myCollision;
    // Player is declared by the operator
    [Tooltip("Define the player here")]
    public Rigidbody2D playerRb;
    [Tooltip("This variable will adjust the velocity that the pad will apply to the player. Positive values move the player up/right, negative values move the player down/left.")]
    public float boostforce;
    [Tooltip("Does this boost pad launch the player horizontally?")]
    public bool IsHorizontal = false;
    
    // Start is called before the first frame update
    void Start()
    {
        myCollision = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Determines if the player is going to be moved vertically or horizontally.
        if (collider.gameObject.CompareTag("Player"))
        {
            if (IsHorizontal == false)
            {
                playerRb.AddForce(new Vector2(playerRb.velocity.x, boostforce + playerRb.velocity.y));
            }
            else if (IsHorizontal == true)
            {
                playerRb.AddForce(new Vector2(boostforce + playerRb.velocity.x, playerRb.velocity.y));
            }
        } 
    }
}
