using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private int extrajump = 2;
    private bool isOnTheGround = false;

    private float force = 10;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnTheGround = true;
            extrajump = 2;
        }
        
    }

    private void Update()
    {




        if ((Input.GetKeyDown(KeyCode.Space) && (isOnTheGround != false)) || ((Input.GetKeyDown(KeyCode.Space)) && (extrajump >= 1)))
        {
            extrajump--;
            isOnTheGround = false;
            


            playerRigidbody.AddForce(Vector3.up * force + -playerRigidbody.velocity , ForceMode.Impulse);
            
        }
        


    }
}
