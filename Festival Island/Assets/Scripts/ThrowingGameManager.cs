using UnityEngine;

public class ThrowingGameManager : MonoBehaviour
{
    bool gameStarted = false;
    public GameObject[] ballPrefabs;
    public GameObject ballPosition;
    public GameObject scoreText,scoreValue,instructions;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameStarted);
        if (!gameStarted) {
            if (other.CompareTag("Coin"))
            {
                NewBallGame();
                Destroy(other.gameObject);
            }
        }
    }

    void NewBallGame()
    {
        gameStarted = true;
        Debug.Log(gameStarted);
        scoreText.SetActive(true);
        scoreValue.SetActive(true);
        instructions.SetActive(false);
        SpawnBalls();
        
    }

    void SpawnBalls()
    {
        //int i = Random.Range(1, ballPrefabs.Length);
        //for (int i = 0; i < ballPrefabs.Length; i++)
        int ballCount = 15;
        while (ballCount>0)
        {
            int j = Random.Range(1, ballPrefabs.Length);
            Instantiate(ballPrefabs[j], ballPosition.transform.position, ballPrefabs[j].transform.rotation);
            ballCount--;
        }
    }
}

