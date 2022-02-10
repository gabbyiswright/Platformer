using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Wind Mechanic To create harder movement
// 2/7/22
// Brandon Sheneman


public class Wind : MonoBehaviour
{
    private Collider2D mycollision;
    public Rigidbody2D PlayerRB;
    // Start is called before the first frame update
    // Rigidbody2D rb;

    void Start()
    {
        mycollision = GetComponent<Collider2D>();
    }

    // Update is called once per frame



    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {

            PlayerRB.AddForce(new Vector2(-12f, 0f));
        }

    }
}



