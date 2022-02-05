using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 10;
    public Vector3 direction;

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
