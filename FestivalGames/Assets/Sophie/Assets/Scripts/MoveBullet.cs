using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed = 8f;
    public float lifeDuration = 5f;

    private float bulletTimer;

    void Start()
    {
        bulletTimer = lifeDuration;
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        bulletTimer -= Time.deltaTime;
        if(bulletTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
