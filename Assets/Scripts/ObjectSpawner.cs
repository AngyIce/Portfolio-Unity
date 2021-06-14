using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] spawnableObjects;
    GameObject objectToSpawn;

    private int xPos;
    private int yPos;
    private int zPos;
    private int objectToGenerate;
    private int objectQuantity = 2000;

    void Start()
    {

        for (int i = 0; i < objectQuantity; i++)
        {
            xPos = Random.Range(-400, 400);
            yPos = Random.Range(-400, 400);
            zPos = Random.Range(-800, 800);

            objectToGenerate = Random.Range(0, spawnableObjects.Length);
            objectToSpawn = spawnableObjects[objectToGenerate];

            Instantiate(objectToSpawn, new Vector3(xPos, yPos, zPos), Quaternion.identity);

        }

    }

}


