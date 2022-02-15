using UnityEngine;

public class AttractAnimal : MonoBehaviour
{
    private float speed = 1.0f;
    private float step; 
    public GameObject deer;
    public GameObject moose;
    public GameObject carrot;
    public Vector3 offset;
    public Vector3 offset2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("food"))
        {
        }
    }
    void Start()
    {
        step = speed * Time.deltaTime;
    }

    void Update()
    {
        deer.transform.position = Vector3.MoveTowards(deer.transform.position, carrot.transform.position + offset, step);
        moose.transform.position = Vector3.MoveTowards(moose.transform.position, carrot.transform.position + offset2, step);
    }
}
