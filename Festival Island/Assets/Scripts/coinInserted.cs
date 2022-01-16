using UnityEngine;

public class coinInserted : MonoBehaviour
{
    public GameObject redBallPrefab, blueBallPrefab;
    public GameObject redBallPosObj, blueBallPosObj;

    Vector3 redBallPos;
    Vector3 blueBallPos;

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
        redBallPos = redBallPosObj.transform.position;
        Instantiate(redBallPrefab, redBallPos, redBallPrefab.transform.rotation);
        blueBallPos = redBallPosObj.transform.position;
        Instantiate(blueBallPrefab, blueBallPos, redBallPrefab.transform.rotation);
    }
}
