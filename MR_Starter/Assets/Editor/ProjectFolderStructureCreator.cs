using UnityEngine;
using System.Collections;
using UnityEditor;

public class ProjectFolderStructureCreator : MonoBehaviour
{

    [MenuItem("MyTools/CreateFolderStructure")]
    static void CreateFolderStructor()
    {
        if (!AssetDatabase.IsValidFolder("Assets/3rd Party"))
            AssetDatabase.CreateFolder("Assets", "3rd Party");

        if (!AssetDatabase.IsValidFolder("Assets/Project Files"))
            AssetDatabase.CreateFolder("Assets", "Project Files");

        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Models"))
            AssetDatabase.CreateFolder("Assets/Project Files", "Models");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Prefabs"))
            AssetDatabase.CreateFolder("Assets/Project Files", "Prefabs");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Images"))
            AssetDatabase.CreateFolder("Assets/Project Files", "Images");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Images/UI"))
            AssetDatabase.CreateFolder("Assets/Project Files/Images", "UI");

        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Images/App"))
            AssetDatabase.CreateFolder("Assets/Project Files/Images", "App");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Scenes"))
            AssetDatabase.CreateFolder("Assets/Project Files", "Scenes");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Scripts"))
            AssetDatabase.CreateFolder("Assets/Project Files", "Scripts");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Scripts/Tests"))
            AssetDatabase.CreateFolder("Assets/Project Files/Scripts", "Tests");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Scenes/Tests"))
            AssetDatabase.CreateFolder("Assets/Project Files/Scenes", "Tests");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Audio"))
            AssetDatabase.CreateFolder("Assets/Project Files", "Audio");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Animations"))
            AssetDatabase.CreateFolder("Assets/Project Files", "Animations");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Videos"))
            AssetDatabase.CreateFolder("Assets/Project Files", "Videos");
        if (!AssetDatabase.IsValidFolder("Assets/Project Files/Materials"))
            AssetDatabase.CreateFolder("Assets/Project Files", "Materials");


    }
}
