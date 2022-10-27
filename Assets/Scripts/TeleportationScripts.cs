using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationScripts : MonoBehaviour
{
    [SerializeField] GameObject HomeBaseTeleportation;
    [SerializeField] GameObject player;
    [SerializeField] Camera   playerHead;

    Vector3 HomeBaseLocation;
    // Start is called before the first frame update
    void Start()
    {
        HomeBaseLocation = HomeBaseTeleportation.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if Y is below a certain limit( 10 )wait 5-10 seconds and teleport to home base
        if(Input.GetAxis("Horizontal") <= 10f)
        {
            gameObject.transform.position = HomeBaseLocation;
        }
        //if y is above a certain limit (26) and z is above a certain limit (29)= made it to other side trigger something
        if(Input.GetAxis("Horizontal") > 26f  )
            {
                if(Input.GetAxis("Horizontal") > 29f)
                    {
            gameObject.transform.position = HomeBaseLocation; 
            //display you win
                    }
            }
    }
}
