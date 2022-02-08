using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysKiller : MonoBehaviour
{
    private Rigidbody2D myRb;
    public Vector3 RespawnPoint = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
        RespawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Kill()
    {
        transform.position = RespawnPoint;
        myRb.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            Kill();
        }
    }
}
