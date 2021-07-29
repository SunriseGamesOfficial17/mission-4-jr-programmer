using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCarScript : Car
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
            Destroy(collision.gameObject);
            CarAction();
        }   
    }

    protected override void CarAction()
    {
        Debug.Log("Your vehicle picked up the crate");
    }
}
