using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collided");
        if (other.gameObject.CompareTag("chicken"))
        {
            //Debug.Log("chicken collided");
            Destroy(other.gameObject);
        }
    }
}
