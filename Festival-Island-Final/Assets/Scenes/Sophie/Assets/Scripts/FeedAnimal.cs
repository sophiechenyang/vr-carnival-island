using UnityEngine;

public class FeedAnimal : MonoBehaviour
{
    Animator m_animator;
    public bool isEating;
    AudioSource m_audioSource;

    void Start()
    {
        m_animator = GetComponent<Animator>();
        m_audioSource = GetComponent<AudioSource>();
        m_audioSource.playOnAwake = false;
    }

    void Update()
    {
        m_animator.SetBool("Eat_b", isEating);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("deerfood"))
        {
            isEating = true;
            m_audioSource.Play();
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("deerfood"))
        {
            isEating = false;
        }
    }
}
