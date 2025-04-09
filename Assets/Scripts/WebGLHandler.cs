using UnityEngine;

public class WebGLHandler : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;

    private void Start()
    {
        // Ensure we find the character controller if not set
        if (characterController == null)
        {
            characterController = FindObjectOfType<CharacterController>();
        }

        // Set up WebGL-specific behavior
        #if UNITY_WEBGL && !UNITY_EDITOR
            // Disable right-click context menu to prevent interruptions
            WebGLInput.captureAllKeyboardInput = true;
            
            // Set appropriate quality level for web
            QualitySettings.SetQualityLevel(2, true); // Medium quality for web
        #endif
    }

    private void Update()
    {
        // Handle web-specific input if needed
        #if UNITY_WEBGL && !UNITY_EDITOR
            // Add any web-specific input handling here if necessary
        #endif
    }
}
