using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerUI : MonoBehaviour
{
    private void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ExitGame();
        }
    }

    private void ExitGame () 
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
