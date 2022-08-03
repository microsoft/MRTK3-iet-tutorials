using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UX;
using UnityEngine.SceneManagement;

public class DialogBox : MonoBehaviour
{
    
    [SerializeField]
    private Dialog dialogPrefabMedium;

    public Dialog DialogPrefabMedium
    {
        get => dialogPrefabMedium;
        set => dialogPrefabMedium = value;
    }

    public void OpenChoiceDialogMedium()
    {
        Dialog myDialog = Dialog.InstantiateFromPrefab(DialogPrefabMedium, new DialogProperty("Choice Dialog, Medium, Near", "Are you sure you want to reset?", DialogButtonHelpers.YesNo), true, true);

        if (myDialog != null)
        {
            myDialog.OnClosed += OnClosedDialogEvent;
        }

        void OnClosedDialogEvent(DialogProperty property)
        {
            if (property.ResultContext.ButtonType == DialogButtonType.Yes)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

    }
}
