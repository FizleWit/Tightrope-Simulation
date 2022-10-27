using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationScripts : MonoBehaviour
{
    [SerializeField] GameObject HomeBaseTeleportation;
    

    Vector3 HomeBaseLocation;


    // Start is called before the first frame update
    void Start()
    {
        HomeBaseLocation = HomeBaseTeleportation.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 playerLocation = gameObject.transform.position;
        //if Y is below a certain limit( 10 )wait 5-10 seconds and teleport to home base
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            TeleportPlayer(HomeBaseLocation);
        }
        //if y is above a certain limit (26) and z is above a certain limit (29)= made it to other side trigger something

    }

    void TeleportPlayer(Vector3 tpLocation)
    {
        gameObject.transform.position = tpLocation;
        Debug.Log(tpLocation + " Teleport reached");
    }
}
