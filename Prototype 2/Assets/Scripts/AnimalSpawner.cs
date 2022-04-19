using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    #region Variables
    public List<GameObject> animals;
    public Quaternion spawnRotation;
    public float spawnRate = 1.5f;
    [Range(0, 15)] public float spawnRangeX;
    [Range(0, 10)] public float spawnRangeZ;
    #endregion

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), 2f, spawnRate);
    }

    void Update()
    {

    }

    void SpawnRandomAnimal() {
        GameObject rndAnimal = animals[Random.Range(0, animals.Count)];
        float spawnPosX = Random.Range(transform.position.x - spawnRangeX, transform.position.x + spawnRangeX);
        float spawnPosZ = Random.Range(transform.position.z - spawnRangeZ, transform.position.z + spawnRangeZ);
        Vector3 rndPos = new Vector3(spawnPosX, 0, spawnPosZ);
        Instantiate(rndAnimal, rndPos, spawnRotation);
    }
}
