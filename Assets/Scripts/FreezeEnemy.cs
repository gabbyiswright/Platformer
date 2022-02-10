using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeEnemy : MonoBehaviour
{
    public float cooldown = 3;
    public GameObject Freezeball;
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
            Shoot();
            Timer = 0;
            
        }

    }

    void Shoot()
    {
        Vector3 spawnpos = transform.position;
        GameObject Fzbl = Instantiate(Freezeball, spawnpos, transform.rotation);

        Fzbl.GetComponent<Rigidbody2D>().velocity = Vector2.down * Shotspeed;
        
    }

}
