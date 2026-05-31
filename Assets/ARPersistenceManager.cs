using UnityEngine;
using Vuforia;

public enum ARLayoutState { GroundedToPaper, FloatingHUD }

public class ARPersistenceManager : MonoBehaviour
{
    [SerializeField] private ObserverBehaviour imageTarget;
    [SerializeField] private GameObject arContentContainer;
    
    [Header("HUD Smooth Transitions")]
    [SerializeField] private Transform arCameraTransform; // Drag your ARCamera here
    [SerializeField] private Vector3 hudLocalPosition = new Vector3(-0.3f, 0f, 1.2f); // Offset left in front of camera
    [SerializeField] private Vector3 hudLocalRotation = new Vector3(0f, 0f, 0f);
    [SerializeField] private float transitionSpeed = 5f;

    private bool hasBeenDetected = false;
    private ARLayoutState currentState = ARLayoutState.GroundedToPaper;
    private Vector3 targetLocalPosition;
    private Quaternion targetLocalRotation;
    private Transform originalParent;

    private void Start()
    {
        if (imageTarget != null)
        {
            imageTarget.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        if (arContentContainer != null)
        {
            originalParent = arContentContainer.transform.parent;
            arContentContainer.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        if (imageTarget != null)
        {
            imageTarget.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    private void Update()
    {
        if (!hasBeenDetected || arContentContainer == null) return;

        // Smoothly lerp towards target positions/rotations depending on layout state
        if (currentState == ARLayoutState.FloatingHUD && arCameraTransform != null)
        {
            // Calculate world position relative to camera view
            Vector3 worldTargetPos = arCameraTransform.TransformPoint(hudLocalPosition);
            Quaternion worldTargetRot = arCameraTransform.rotation * Quaternion.Euler(hudLocalRotation);

            arContentContainer.transform.position = Vector3.Lerp(arContentContainer.transform.position, worldTargetPos, Time.deltaTime * transitionSpeed);
            arContentContainer.transform.rotation = Quaternion.Slerp(arContentContainer.transform.rotation, worldTargetRot, Time.deltaTime * transitionSpeed);
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        Status status = targetStatus.Status;

        if (status == Status.TRACKED || status == Status.EXTENDED_TRACKED)
        {
            if (!hasBeenDetected)
            {
                hasBeenDetected = true;
                arContentContainer.SetActive(true);
            }
            
            // Re-parent to image target to smoothly follow paper physics movements
            if (currentState != ARLayoutState.GroundedToPaper)
            {
                currentState = ARLayoutState.GroundedToPaper;
                arContentContainer.transform.SetParent(originalParent);
                arContentContainer.transform.localPosition = Vector3.zero;
                arContentContainer.transform.localRotation = Quaternion.identity;
            }
        }
        else if (status == Status.NO_POSE || status == Status.LIMITED)
        {
            if (hasBeenDetected)
            {
                arContentContainer.SetActive(true);
                
                // Detach from the lost tracking target, snap layout to follow camera view space
                if (currentState != ARLayoutState.FloatingHUD)
                {
                    currentState = ARLayoutState.FloatingHUD;
                    arContentContainer.transform.SetParent(null); // World space anchor
                }
            }
        }
    }

    public void ResetExperience()
    {
        hasBeenDetected = false;
        currentState = ARLayoutState.GroundedToPaper;
        if (arContentContainer != null)
        {
            arContentContainer.transform.SetParent(originalParent);
            arContentContainer.SetActive(false);
        }
    }
}