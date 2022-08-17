using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class SceneControl : MonoBehaviour
{
    private UIElement uiReplay;
    private UIElement uiQuit;

    private string nameSceneToReplay = "籃球場";
    private void Awake()
    {
        uiReplay = GameObject.Find("重新").GetComponent<UIElement>();
        uiQuit = GameObject.Find("離開").GetComponent<UIElement>();

        uiReplay.onHandClick.AddListener((UnityAction) => { SceneManager.LoadScene(nameSceneToReplay); });
        uiQuit.onHandClick.AddListener((UnityAction) => { Application.Quit(); });
    }
}
