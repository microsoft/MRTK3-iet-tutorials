using UnityEngine;
using UnityEditor;
using Unity.Tutorials.Core.Editor;
using Microsoft.MixedReality.Toolkit.UX;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.SpatialManipulation;
using Microsoft.MixedReality.Toolkit.Data;
using TMPro;

/// <summary>
/// Implement your Tutorial callbacks here.
/// </summary>
[CreateAssetMenu(fileName = DefaultFileName, menuName = "Tutorials/" + DefaultFileName + " Instance")]
public class TutorialCallbacks : ScriptableObject
{
    /// <summary>
    /// The default file name used to create asset of this class type.
    /// </summary>
    public const string DefaultFileName = "TutorialCallbacks";

    /// <summary>
    /// Creates a TutorialCallbacks asset and shows it in the Project window.
    /// </summary>
    /// <param name="assetPath">
    /// A relative path to the project's root. If not provided, the Project window's currently active folder path is used.
    /// </param>
    /// <returns>The created asset</returns>
    public static ScriptableObject CreateAndShowAsset(string assetPath = null)
    {
        assetPath = assetPath ?? $"{TutorialEditorUtils.GetActiveFolderPath()}/{DefaultFileName}.asset";
        var asset = CreateInstance<TutorialCallbacks>();
        AssetDatabase.CreateAsset(asset, AssetDatabase.GenerateUniqueAssetPath(assetPath));
        EditorUtility.FocusProjectWindow(); // needed in order to make the selection of newly created asset to really work
        Selection.activeObject = asset;
        return asset;
    }

    /// <summary>
    /// Example callback for basic UnityEvent
    /// </summary>
    public void ExampleMethod()
    {
        Debug.Log("ExampleMethod");
    }

    /// <summary>
    /// Example callbacks for ArbitraryCriterion's BoolCallback
    /// </summary>
    /// <returns></returns>
    public bool DoesFooExist()
    {
        return GameObject.Find("Foo") != null;
    }

    /// <summary>
    /// Implement the logic to automatically complete the criterion here, if wanted/needed.
    /// </summary>
    /// <returns>True if the auto-completion logic succeeded.</returns>
    public bool AutoComplete()
    {
        var foo = GameObject.Find("Foo");
        if (!foo)
            foo = new GameObject("Foo");
        return foo != null;
    }

    public bool MoveManipulationSelected()
    {
        var coralObject = GameObject.Find("Coral");

        return coralObject.GetComponent<ObjectManipulator>().AllowedManipulations == Microsoft.MixedReality.Toolkit.TransformFlags.Move;
    }

    public bool BoundsPrefabAssigned()
    {
        var coralObject = GameObject.Find("Coral");

        return coralObject.GetComponent<BoundsControl>().BoundsVisualsPrefab;
    }

    public bool AreHandlesActive()
    {
        var rockObject = GameObject.Find("Rock");

        return rockObject.GetComponent<BoundsControl>().HandlesActive == true;
    }

    public bool SeaTurtleButtonCreated()
    {
        return GameObject.Find("SeaTurtleButton") != null;
    }


    public bool SeaTurtleButtonParameters()
    {
        var buttonObject = GameObject.Find("TextMeshPro");

        return buttonObject.GetComponent<TextMeshPro>().text == "Sea Turtle" && buttonObject.GetComponent<TextMeshPro>().fontSize == 0.1f;
    }

    /*public bool ButtonBarParameters()
    {
        var buttonBarObject = GameObject.Find("ObjectsButtonBar");
        Vector3 barPos = new Vector3(0, 0, 0);
        return buttonBarObject.GetComponent<RectTransform>().position == barPos;
    }*/

    /*public bool ButtonBarChildrenExist()
    {
        return GameObject.Find("Coral") != null && GameObject.Find("Rock") != null && GameObject.Find("Seahorse") != null && GameObject.Find("Turtle") != null && GameObject.Find("Dolphin") != null;
    }*/

    /*public bool dataSourceType()
    {
        var themeProviderObject = GameObject.Find("Theme Provider");

        return themeProviderObject.GetComponent<DataSourceThemeProvider>().DataSourceType == "theme";
    }*/

    /*public bool dialogPrefabExists()
    {
        var dialogObject = GameObject.Find("Dialog");
        var resetSceneComponent = dialogObject.GetComponent<ResetScene>();
    }*/

    /*public bool dialogCreated()
    {
        return GameObject.Find("Dialog") != null;
    }*/

    /*public bool resetSceneExists()
    {
        var dialogObject = GameObject.Find("Dialog");
        return dialogObject.GetComponent<ResetScene>() != null;
    }*/

    /*public bool dataSourceThemeProviderConfigured()
    {
        var dataSourceThemeProviderObject = GameObject.Find("ThemeProvider");

        return GameObject.Find("ThemeProvider") != null && GetComponent("DataSourceThemeProvider") != null && dataSourceThemeProviderObject.GetComponent<DataSourceThemeProvider>().DataSourceType == "theme";
    }*/
}
