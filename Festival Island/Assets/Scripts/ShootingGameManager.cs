using UnityEngine;

public class ShootingGameManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    public int shootingScore = 0;

    private float spawnInterval = 1.5f;
    private bool gameStarted = false;

    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided");
        if(other.CompareTag("Coin") && !gameStarted)
        {
            NewShootingGame();
            Destroy(other.gameObject);
        }
    }
    void NewShootingGame()
    {
        gameStarted = true;
        InvokeRepeating("SpawnAnimals", 0, spawnInterval);
        Debug.Log(gameStarted);
        Debug.Log("new shooting game");
    }

    void SpawnAnimals()
    {
        Vector3 spawnPos = new Vector3(12, 0, Random.Range(23, 28));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
