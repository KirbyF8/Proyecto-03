using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private float speed = 10f;

    private float RepeatWidht;
    private float xrange = -112.8f;
    private PlayerController PlayerControllerScript;


    private void Start()
    {
        PlayerControllerScript = FindObjectOfType<PlayerController>();
        RepeatWidht = GetComponent<BoxCollider>().size.x;

    }
    void Update()
    {
        if (!PlayerControllerScript.GameOver) 
        { 
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        Vector3 position = transform.position;

        if (position.x <= xrange)
        {
            transform.Translate(-xrange * 3, 0,0);

        }
        }
    }
}
