using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public float speed;
    public bool movingRight = false;

    public Transform frontDetection;
    public Transform backDetection;

    private Rigidbody2D myRB;

    public float groundRayDist = 2f;
    public float wallRayDist = 0.2f;

    [Tooltip("Drag the Projectile prefab here to use")]
    public GameObject projectile;

    public Vector3 Offset1 = new Vector3(0, 0, 0);
    public Vector3 Offset2 = new Vector3(0, 0, 0);
    public float Cooldown = 0.2f;
    float Timer = 0;
    public float LaserSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDir;

        if (movingRight)
        {
            moveDir = Vector2.right;

        }
        else
        {
            moveDir = -Vector2.right;
        }

        myRB.AddForce(moveDir * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(frontDetection.position, Vector2.down, groundRayDist);
        RaycastHit2D backGroundInfo = Physics2D.Raycast(backDetection.position, Vector2.down, groundRayDist);
        RaycastHit2D wallInfo = Physics2D.Raycast(frontDetection.position, moveDir, wallRayDist);
        RaycastHit2D backWallInfo = Physics2D.Raycast(backDetection.position, -moveDir, wallRayDist);
        //make sure that it can keep going a direction or switch, or just stop turning if trapped on both sides
        //if there wasn't a back check it would spaz if pushed into a strange place
        if ((groundInfo.collider == false || wallInfo.collider != false) && (backGroundInfo.collider == true && backWallInfo.collider != true))
        {
            movingRight = !movingRight;
            transform.eulerAngles += new Vector3(0, 180, 0);
        }

        Timer += Time.deltaTime;
        if (Timer >= Cooldown)
        {
            //fire objects
            Fire(Offset1);
            //Fire(Offset2);
            Timer = 0;
        }

    }

    void Fire(Vector3 offset)
    {
        Vector3 spawnpos = transform.position + transform.rotation * offset;
        GameObject slime1 = Instantiate(projectile, spawnpos, transform.rotation);

        if (movingRight)
        { 
            slime1.GetComponent<PatrolEnemy>().movingRight = true;
        }
        else 
        {
            slime1.GetComponent<PatrolEnemy>().movingRight = false;
        }
    }
}
