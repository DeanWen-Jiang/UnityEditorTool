using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// 图片导入工程预处理
/// </summary>
public class SpriteProcessor : AssetPostprocessor
{
    void OnPostProcessTexture(Texture2D texture) {
        string lowCaseAssetPath = assetPath.ToLower();
        bool isInSpriteDirectory = lowCaseAssetPath.IndexOf("/sprites/") !=  -1 ;

        if (isInSpriteDirectory) {
            TextureImporter textureImporter = (TextureImporter)assetImporter;
            textureImporter.textureType = TextureImporterType.Sprite;
        }
    }
}
