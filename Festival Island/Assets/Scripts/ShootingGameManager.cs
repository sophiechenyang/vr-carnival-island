using UnityEngine;

public class ShootingGameManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalCount = 5;

    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnAnimals", 0, spawnInterval);
    }

    void Update()
    {
        //if (animalCount > 0)
        //{
        //    SpawnAnimals();
        //}
    }

    void SpawnAnimals()
    {
        Vector3 spawnPos = new Vector3(12, 0, Random.Range(23, 28));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        animalCount--;
    }
}
