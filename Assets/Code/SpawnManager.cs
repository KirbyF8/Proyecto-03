using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private float SpawnDelay = 1.5f;
    private float StartDelay = 3f;
    private float objectY;
    [SerializeField] private GameObject[] obstacleArray;
    private int obstacleIndex;
    private int lastObject = 2;
    private int MAS = 30;
    private float cameraLimitY = 8f;

    private PlayerController PlayerControllerScript;

    private Vector3 spawnplace;

    private void Start()
    {
        InvokeRepeating("SpawnRandomObject", StartDelay, SpawnDelay);
        PlayerControllerScript = FindObjectOfType<PlayerController>();
    }

  

    private void SpawnRandomObject()
    {
        if (!PlayerControllerScript.GameOver)
        {
            obstacleIndex = Random.Range(0, obstacleArray.Length);
            objectY = Random.Range(0, cameraLimitY);
            if (lastObject == obstacleIndex)
            {
                obstacleIndex = Random.Range(0, obstacleArray.Length);
            }
            else
            {
                Instantiate(obstacleArray[obstacleIndex], new Vector3(30, 0, 0), Quaternion.Euler(0, 0, 0));
                lastObject = obstacleIndex;
                MAS--;
            }
        }
    }
}
