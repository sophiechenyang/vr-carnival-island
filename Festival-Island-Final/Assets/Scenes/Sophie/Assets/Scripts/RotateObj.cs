using UnityEngine;

public class RotateObj : MonoBehaviour
{
    public Vector3 vect;

    void Update()
    {
        transform.Rotate(vect * Time.deltaTime);
    }
}
