using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public float speed = 3f;
    public GameObject targetPosObj;

    private Vector3 targetPos;

    void Start()
    {
        targetPos = targetPosObj.transform.position;
    }
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
    }
}
