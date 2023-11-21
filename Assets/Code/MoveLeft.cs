using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 12f;
    private PlayerController PlayerControllerScript;

    private void Start()
    {
        PlayerControllerScript = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerControllerScript.GameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
        
        if (transform.position.x <= -30)
        {
            Destroy(gameObject);    
        }
        
    }


}
