using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Haptics : MonoBehaviour
{
    public ActionBasedController xr;
    public string m_tag = "petting";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(m_tag))
        {
            ActivateHaptic();
        }
        
    }

    void ActivateHaptic()
    {
        xr.SendHapticImpulse(0.4f, 3f);
    }
}
