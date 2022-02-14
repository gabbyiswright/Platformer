using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeEnemy : MonoBehaviour
{
    
    public float cooldown = 3;
    public GameObject Freezeball;
    public Vector3 snowball = new Vector3(0, 0, 0);
    float Timer = 0;
    public float Shotspeed = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Timer += Time.deltaTime;
        if (Timer >= cooldown)
        {
            //fire objects
            Shoot(snowball);
            Timer = 0;
        }

    }

    void Shoot(Vector2 snowball)
    {
        Vector3 spawn = transform.position;
        GameObject las1 = Instantiate(Freezeball, spawn, transform.rotation);

        las1.GetComponent<Rigidbody2D>().velocity = Vector2.down * Shotspeed;
    }

}
