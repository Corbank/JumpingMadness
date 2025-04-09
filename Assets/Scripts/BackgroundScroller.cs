using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroller : MonoBehaviour
{
    [Header("Scrolling Settings")]
    [SerializeField] private float scrollSpeed = 0.5f;
    [SerializeField] private bool scrollX = true;
    [SerializeField] private bool scrollY = false;
    
    private RawImage backgroundImage;
    private Vector2 initialOffset;
    
    private void Start()
    {
        backgroundImage = GetComponent<RawImage>();
        initialOffset = backgroundImage.uvRect.position;
    }
    
    private void Update()
    {
        // Calculate scroll offset
        float offsetX = scrollX ? Time.time * scrollSpeed : 0;
        float offsetY = scrollY ? Time.time * scrollSpeed : 0;
        
        // Apply scrolling to background image
        backgroundImage.uvRect = new Rect(
            initialOffset.x + offsetX, 
            initialOffset.y + offsetY, 
            backgroundImage.uvRect.width, 
            backgroundImage.uvRect.height
        );
    }
}
