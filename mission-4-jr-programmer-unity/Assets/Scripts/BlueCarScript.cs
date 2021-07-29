using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCarScript : Car
{
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CarHorn(audioSource, audioClip);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            CarHornStop(audioSource);
        }

        CarMove(speed, turnSpeed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Crate"))
        {
            CarAction();
        }   
    }
}
