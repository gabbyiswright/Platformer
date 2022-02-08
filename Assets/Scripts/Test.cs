using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
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

        
            PlayerRB.AddForce(new Vector2(10f, 0f));
        

    }
}


