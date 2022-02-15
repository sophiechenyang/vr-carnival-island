using UnityEngine;
using TMPro;

public class ShootingGameManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject instructionTxt;
    public GameObject scoreTxt;
    public GameObject gameOverTxt;
    private TextMeshPro scoreText;

    public int shootingScore = 0;
    private float spawnInterval = 1.5f;
    private bool gameStarted = false;
    private int chickenCount = 0;
    private int maxChickenSpawned = 20;

    private AudioSource m_audio;

    void Start()
    {
        m_audio = GetComponent<AudioSource>();
        scoreText = scoreTxt.GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin") && !gameStarted)
        {
            NewShootingGame();
            Destroy(other.gameObject);
        }
    }
    void NewShootingGame()
    {
        Debug.Log("starting game");
        m_audio.Play();
        shootingScore = 0;
        chickenCount = 0;
        gameStarted = true;
        instructionTxt.SetActive(false);
        gameOverTxt.SetActive(false);
        scoreTxt.SetActive(true);
        scoreText.SetText("0");
        InvokeRepeating("SpawnAnimals", 0, spawnInterval);

    }

    void SpawnAnimals()
    {
        Vector3 spawnPos = new Vector3(12, 0, Random.Range(23, 28));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        if (gameStarted && chickenCount <= maxChickenSpawned)
        {
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        chickenCount++;
    }

    void Update()
    {
        if (gameStarted && chickenCount >= maxChickenSpawned)
        {
            EndShootingGame();
        }
    }

    void EndShootingGame()
    {
        gameStarted = false;
        gameOverTxt.SetActive(true);
        chickenCount = 0;
    }
}
