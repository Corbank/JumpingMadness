using UnityEditor;
using UnityEngine;
using System.IO;

public class WebGLBuilder
{
    [MenuItem("Build/Build WebGL")]
    public static void BuildWebGL()
    {
        // Define build output directory
        string outputDir = Path.Combine(Application.dataPath, "..", "WebGLBuild");
        
        // Create directory if it doesn't exist
        if (!Directory.Exists(outputDir))
        {
            Directory.CreateDirectory(outputDir);
        }
        
        // Configure WebGL build settings
        PlayerSettings.WebGL.template = "Minimal";
        PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Gzip;
        PlayerSettings.WebGL.linkerTarget = WebGLLinkerTarget.Wasm;
        PlayerSettings.WebGL.dataCaching = true;
        
        // Build the project
        BuildPipeline.BuildPlayer(
            EditorBuildSettings.scenes,
            outputDir,
            BuildTarget.WebGL,
            BuildOptions.None
        );
        
        Debug.Log("WebGL build completed! Output directory: " + outputDir);
    }
    
    [MenuItem("Build/Open WebGL Build Settings")]
    public static void OpenWebGLBuildSettings()
    {
        EditorWindow.GetWindow<BuildPlayerWindow>();
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.WebGL, BuildTarget.WebGL);
    }
}
