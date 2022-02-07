using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedAnimal : MonoBehaviour
{
    Animator m_animator;
    public bool isEating;

    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        m_animator.SetBool("Eat_b", isEating);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("food"))
        {
            isEating = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("food"))
        {
            isEating = false;
        }
    }
}
