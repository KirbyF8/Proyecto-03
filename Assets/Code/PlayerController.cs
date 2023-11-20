using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
}
