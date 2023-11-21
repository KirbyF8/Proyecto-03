using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private int extrajump = 2;
    private bool isOnTheGround = false;
    public bool GameOver = false;

    private float force = 10;

    private void Awake()
    {
        GameOver = false;
        playerRigidbody = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("mondongo!");

        if (collision.gameObject.CompareTag("Obstacles"))
        {
            Debug.Log("Game Over");
            GameOver = true;
            extrajump = 0;
            
            

        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            extrajump = 2;
            isOnTheGround = true;

        }

        

    }

    private void Update()
    {




        if ((Input.GetKeyDown(KeyCode.Space) && (isOnTheGround != false)) && (!GameOver) || ((Input.GetKeyDown(KeyCode.Space)) && (extrajump >= 1)) && (!GameOver))
        {
            extrajump--;
            isOnTheGround = false;
            playerRigidbody.AddForce(Vector3.up * force + -playerRigidbody.velocity , ForceMode.Impulse);
            
        }
        


    }
}
