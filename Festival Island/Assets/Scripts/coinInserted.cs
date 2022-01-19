using UnityEngine;

public class coinInserted : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballPos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            NewBallGame();
        }
    }

    void NewBallGame()
    {
        SpawnBalls();
    }

    void SpawnBalls()
    {
        int count = 10;
        while(count > 0)
        {
            Instantiate(ballPrefab, ballPos.transform.position, ballPrefab.transform.rotation);
            count--;
        }
    }
}
