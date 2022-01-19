using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(gameObject);
        }
    }
}
