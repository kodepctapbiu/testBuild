using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Builder
{
    [RuntimeInitializeOnLoadMethod]
    public static void TryBuild()
    {
        foreach(var arg in Environment.GetCommandLineArgs())
        {
            if(arg == "-BuildMyTarget")
            {
                var res = BuildPipeline.BuildPlayer(new[] { "1.unity" }, Path.Combine(Path.GetDirectoryName(Application.dataPath), "builds\\1.exe"), BuildTarget.StandaloneWindows64, BuildOptions.None);
                EditorApplication.Exit(string.IsNullOrEmpty(res) ? 1 : 0);
            }
        }
    }
}
