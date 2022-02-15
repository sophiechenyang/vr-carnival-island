using UnityEngine;

public class DeerFoodManager : MonoBehaviour
{
    public GameObject deerFood;
    public GameObject foodPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Instantiate(deerFood, foodPos.transform.position, foodPos.transform.rotation);
        }
    }
}
