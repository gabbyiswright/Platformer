using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*****************
 * By Michael Donovan
******************/

//Turns an object into a "boost pad", which launches the player at a specified velocity and direction.
public class BoostPad : MonoBehaviour
{
    private Collision2D myCollision;
    // Player is declared by the operator
    [Tooltip("Define the player here")]
    public Rigidbody2D playerRb;
    [Tooltip("This variable will adjust the velocity that the pad will apply to the player.")]
    public float boostforce;
    
    // Start is called before the first frame update
    void Start()
    {
        myCollision = GetComponent<Collision2D>();
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    private void OnCollisionStay2D(Collision2D collision)
    {
        playerRb.AddForce(new Vector2(playerRb.velocity.x, boostforce));
    }
}
