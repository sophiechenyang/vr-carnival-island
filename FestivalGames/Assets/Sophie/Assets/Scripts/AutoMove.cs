using UnityEngine;

public class AutoMove: MonoBehaviour
{
    Vector3 origin;
    public float speed = 1.2f;
    public float amplitude;

    private void Start()
    {
        origin = transform.position;
    }

    void calculateSin()
    {
        Mathf.Sin(speed * Time.time);
    }

    void Update()
    {
        Vector3 curve = new Vector3(0,0,(Mathf.Sin(speed * Time.time))* amplitude);
        transform.position = curve + origin;
    }
}
