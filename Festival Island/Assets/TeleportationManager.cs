using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationManager : MonoBehaviour
{
    [SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private XRRayInteractor rayInteractor;
    [SerializeField] private TeleportationProvider teleProvider;
    private InputAction _thumbstick;
    private bool _isActive;

    void Start()
    {
        var activate = actionAsset.FindActionMap("XRI LeftHand").FindAction("Teleport Mode Activate");
        activate.Enable();
        activate.performed += OnTeleportActivate;

        var cancel = actionAsset.FindActionMap("XRI LeftHand").FindAction("Teleport Mode Cancel");
        cancel.Enable();
        cancel.performed += OnTeleportCancel;

        var _thumbstick = actionAsset.FindActionMap("XRI LeftHand").FindAction("Move");
        _thumbstick.Enable();
    }

    void Update()
    {
        if (!_isActive)
            return;

        if (_thumbstick.triggered)
        {
            return;
        }

        if (!rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit)) // if raycast does not hit anything, turn teleportation off
        {
            _isActive = false;
            return;
        }

        TeleportRequest request = new TeleportRequest()
        {
            destinationPosition = hit.point
        };

        teleProvider.QueueTeleportRequest(request);

    }

    void OnTeleportActivate(InputAction.CallbackContext context)
    {
        _isActive = true;
    }

    void OnTeleportCancel(InputAction.CallbackContext context)
    {
        _isActive = false;
    }
}
