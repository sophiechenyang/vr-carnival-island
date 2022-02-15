using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public float speed = 3f;
    private GameObject targetPosObj;
    public Vector3 offset;

    Animator m_animator;

    void Start()
    {
        m_animator = GetComponent<Animator>();
    }
    void Update()
    {
        targetPosObj = GameObject.FindGameObjectWithTag("deerfood");
        if (targetPosObj)
        {
            Vector3 direction = targetPosObj.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            
            
            float tarDistance = Vector3.Distance(transform.position, targetPosObj.transform.position);
            float step = speed * Time.deltaTime;

            if (tarDistance > 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosObj.transform.position + offset, step);
                m_animator.SetFloat("Speed_f", 0.3f);
                
            } else
            {
                m_animator.SetFloat("Speed_f", 0.0f);
            }

            if (tarDistance > 3)
            {
                transform.rotation = rotation;
            }




        }
    }
}
