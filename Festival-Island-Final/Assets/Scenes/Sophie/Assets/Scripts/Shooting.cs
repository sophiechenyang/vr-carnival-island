using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shooting : MonoBehaviour
{
    XRGrabInteractable gun;
    public GameObject bullet;
    public GameObject detector;
    public Camera playerCamera;
    public Vector3 offset;

    GameObject m_bullet;

    void Start()
    {
        gun = GetComponent<XRGrabInteractable>();
        gun.onActivate.AddListener(FireBullet);
        gun.onDeactivate.AddListener(Destroy);
    }

    void FireBullet(XRBaseInteractor interactor)
    {
        m_bullet = Instantiate(bullet);
        m_bullet.transform.position = playerCamera.transform.position + offset;
        m_bullet.transform.forward = gun.transform.forward;
        detector.SetActive(true);
    }

    void Destroy(XRBaseInteractor interactor)
    {
        detector.SetActive(false);
    }
}
