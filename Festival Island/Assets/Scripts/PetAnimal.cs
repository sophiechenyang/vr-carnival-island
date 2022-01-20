using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PetAnimal : MonoBehaviour
{
    XRGrabInteractable animal;
    public GameObject detector;

    private void Awake()
    {
        animal = GetComponent<XRGrabInteractable>();
        animal.onActivate.AddListener(ShowCube);
        animal.onDeactivate.AddListener(HideCube);
    }

    void ShowCube(XRBaseInteractor interactor)
    {
        detector.SetActive(true);
    }

    void HideCube(XRBaseInteractor interactor)
    {
        detector.SetActive(false);
    }
}
