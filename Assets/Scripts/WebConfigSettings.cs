using UnityEngine;

[CreateAssetMenu(fileName = "WebConfig", menuName = "Jumping Madness/Web Config")]
public class WebConfigSettings : ScriptableObject
{
    [Header("Web Settings")]
    public bool mobileFriendlyControls = true;
    public int targetFrameRate = 60;
    public bool disableContextMenu = true;

    [Header("Performance")]
    [Range(0, 5)]
    public int qualityLevel = 2; // Medium quality
    public bool optimizeForMobile = true;
}
