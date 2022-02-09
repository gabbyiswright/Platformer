using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftBoost : MonoBehaviour
{
    float Timer = 0;
    float cooldown = 5;


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
            if(Input.GetKeyDown(KeyCode.LeftShift));
            {

            }
                
            Timer = 0;
        }
    }
}
