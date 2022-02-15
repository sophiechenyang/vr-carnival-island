using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Haptics : MonoBehaviour
{
    private ActionBasedController xr;

    void Start()
    {
        xr = (ActionBasedController)GameObject.FindObjectOfType(typeof(ActionBasedController));
    }

    private void OnTriggerEnter(Collider other)
    {
        xr.SendHapticImpulse(0.4f, 3f);
    }
}
