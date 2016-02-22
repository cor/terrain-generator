﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof (MapGenerator))]
public class MapGeneratorEditor : Editor {

    public override void OnInspectorGUI() {
        MapGenerator mapGenerator = (MapGenerator) target;
        
        if (DrawDefaultInspector()) {
            if(mapGenerator.shouldAutoUpdate) {
                mapGenerator.GenerateMap();
            }
        }
        
        if(GUILayout.Button("Generate")) {
            mapGenerator.GenerateMap();
        }
    }
}
