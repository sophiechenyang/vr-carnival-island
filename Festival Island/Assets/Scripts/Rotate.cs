using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 vect;

    void Update()
    {
        transform.Rotate(vect * Time.deltaTime);
    }
}
