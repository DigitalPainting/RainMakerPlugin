using UnityEditor;
using UnityEngine;

public class RainMakerPackageBuilder : PackageBuilder {
    [MenuItem("Digital Painting/Build/Build RainMaker Plugin")]
    new public static void Build()
    {
        string[] rootDirs = { "Assets\\Digital Painting\\Plugins\\Weather_RainMaker" };
        string packageName = @"..\WeatherRainMaker.unitypackage";

        foreach (string rootDir in rootDirs)
        {
            MoveExcludedFiles(rootDir);
        }

        AssetDatabase.ExportPackage(rootDirs, packageName, ExportPackageOptions.Interactive | ExportPackageOptions.Recurse);
        Debug.Log("Exported " + packageName);

        foreach (string rootDir in rootDirs)
        {
            RecoverExcludedFiles(rootDir);
        }
    }
}
