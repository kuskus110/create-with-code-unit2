using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    #region Variables
    public List<GameObject> animals;
    public float spawnRate = 1.5f;
    public float spawnPosZ = 18f;
    public Transform leftWall;
    public Transform rightWall;
    private float leftBoundaryX;
    private float rightBoundaryX;
    private System.Random sysRnd = new System.Random();
    #endregion

    void Start()
    {
        leftBoundaryX = leftWall.position.x;
        rightBoundaryX = rightWall.position.x;
        InvokeRepeating(nameof(SpawnRandomAnimal), 2f, spawnRate);
    }

    void Update()
    {

    }

    void SpawnRandomAnimal() {
        GameObject rndAnimal = animals[Random.Range(0, animals.Count)];
        Vector3 rndPos = new Vector3(Random.Range(leftBoundaryX, rightBoundaryX), 0, spawnPosZ);
        Instantiate(rndAnimal, rndPos, rndAnimal.transform.rotation);
    }
}
