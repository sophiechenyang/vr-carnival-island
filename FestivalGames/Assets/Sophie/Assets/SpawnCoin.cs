using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coin;
    public GameObject coinSpawnPos;

    private int coinCount = 5;

    void Start()
    {
        while (coinCount > 0)
        {
            Instantiate(coin, coinSpawnPos.transform.position, coin.transform.rotation);
            coinCount--;
        }
    }
}
