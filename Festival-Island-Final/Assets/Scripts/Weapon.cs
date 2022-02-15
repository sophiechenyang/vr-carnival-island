using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Weapon : MonoBehaviour
{
   
    public float SwordVelocity;
    Vector3 lastdirectionRef;
    public Vector3 direct;
    public XRController xRController;
    public bool canSlice = false;
    public GameObject slicePanel;
    private void Start()
    {
        xRController = transform.GetComponentInParent<XRController>();
    }
    public void Vibrate(float time)
    {
        xRController.SendHapticImpulse(1, time);
    }
    // manually calculate  velocity
    public void Update()
    {
        direct = transform.position - lastdirectionRef;
        lastdirectionRef = transform.position;
        SwordVelocity = direct.magnitude / Time.deltaTime;

        direct = direct.normalized;
        //when velocity reach 60, the sword can slice items
        if (Vector3.Angle(direct, transform.forward) <= 60)
        {
            canSlice = true;
        }
        else
        {
            canSlice = false;
        }
    }
}

