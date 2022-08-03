using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UX;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{

    [SerializeField]
    private Dialog dialogPrefab;

    public Dialog DialogPrefab
    {
        get => dialogPrefab;
        set => dialogPrefab = value;
    }

    public void ResetSceneDialog()
    {
        Dialog myDialog = Dialog.InstantiateFromPrefab(DialogPrefab, new DialogProperty("Choice Dialog, Medium, Near", "Are you sure you want to reset?", DialogButtonHelpers.YesNo), true, true);

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
