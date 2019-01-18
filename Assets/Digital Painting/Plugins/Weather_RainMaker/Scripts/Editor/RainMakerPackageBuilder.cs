using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RainMakerPackageBuilder : PackageBuilder {
    [MenuItem("Digital Painting/Build/Build RainMaker Plugin")]
    new public static void Build()
    {

        string rootDir = "Assets\\Digital Painting\\Plugins\\Weather_RainMaker";
        string excludeSubDir = "";
        string packageName = "DigitalPainting.unitypackage";

        DeleteAllButPackages(rootDir, excludeSubDir);
        BuildPackage(rootDir, packageName);
        ReinstateFiles(rootDir, excludeSubDir);
    }
}
