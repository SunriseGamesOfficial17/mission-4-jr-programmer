using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    protected float speed, turnSpeed;

    protected float horizontalAxis, verticalAxis;

    protected Rigidbody playerRb;
    
    [SerializeField]
    protected AudioClip audioClip;
    [SerializeField]
    protected AudioSource audioSource;

    protected void CarMove(float moveSpeed, float rotateSpeed)
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        playerRb.AddRelativeForce(Vector3.forward * moveSpeed * verticalAxis * Time.deltaTime);

        transform.Rotate(Vector3.up * rotateSpeed * horizontalAxis * Time.deltaTime);
    }

    protected void CarHorn(AudioSource hornSource, AudioClip hornClip)
    {
        hornSource.clip = hornClip;
        hornSource.Play();
    }

    protected void CarHornStop(AudioSource hornSource)
    {
        hornSource.Stop();
    }

    protected virtual void CarAction()
    {
        Debug.Log("Your vehicle collided with the crate");
    }

}
