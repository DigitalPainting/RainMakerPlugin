using UnityEditor;
using UnityEngine;

public class RainMakerPackageBuilder : PackageBuilder {
    [MenuItem("Digital Painting/Build/Build RainMaker Plugin")]
    new public static void Build()
    {
        string rootDir = "Assets\\Digital Painting\\Plugins\\Weather_RainMaker";
        string packageName = "WeatherRainMaker.unitypackage";

        MoveExcludedFiles(rootDir);

        AssetDatabase.ExportPackage(rootDir, packageName, ExportPackageOptions.Interactive | ExportPackageOptions.Recurse);
        Debug.Log("Exported " + packageName);

        RecoverExcludedFiles(rootDir);
    }
}
