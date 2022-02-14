using UnityEngine;

public class AttractAnimal : MonoBehaviour
{
    private float speed = 1.0f;
    public GameObject sphere;
    public GameObject deer;
    public GameObject moose;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("food"))
        {
            sphere.SetActive(true);
            float step = speed * Time.deltaTime;
            deer.transform.position = Vector3.MoveTowards(deer.transform.position, other.transform.position, step);
            moose.transform.position = Vector3.MoveTowards(moose.transform.position, other.gameObject.transform.position, step);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
