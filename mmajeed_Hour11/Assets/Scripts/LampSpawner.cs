using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampSpawner : MonoBehaviour
{
    public GameObject streetLampPrefab; // Reference to your street lamp prefab
    public int numberOfLamps = 10;

    void Start()
    {
        SpawnLamps();
    }

    void SpawnLamps()
    {
        for (int i = 0; i < numberOfLamps; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
            Instantiate(streetLampPrefab, randomPosition, Quaternion.identity);
        }
    }
}
