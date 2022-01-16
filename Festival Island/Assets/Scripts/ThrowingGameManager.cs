using UnityEngine;

public class ThrowingGameManager : MonoBehaviour
{
    bool gameStarted = false;
    public GameObject[] ballPrefabs;
    public GameObject[] ballPositions;

    //public Vector3[] ballPos;

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
        SpawnBalls();
        
    }

    void SpawnBalls()
    {
        for (int i = 0; i < ballPrefabs.Length; i++)
        {
            Instantiate(ballPrefabs[i], ballPositions[i].transform.position, ballPrefabs[i].transform.rotation);
        }
    }
}

