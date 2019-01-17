using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RainMakerPackageBuilder : PackageBuilder {

    [MenuItem("Digital Painting/Build/Build Rain Maker Package")]
    new public static void Build()
    {
        string pluginName = "Weather_RainMaker";
        string rootDir = "Assets/Digital Painting/Plugins/" + pluginName;
        string packageName = pluginName + ".unitypackage";

        AssetDatabase.ExportPackage(rootDir, packageName, ExportPackageOptions.Interactive | ExportPackageOptions.Recurse);
        Debug.Log("Exported " + packageName);
    }
}
