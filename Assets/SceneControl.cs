using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class SceneControl : MonoBehaviour
{
    private UIElement uiReplay;
    private UIElement uiQuit;

    private string nameSceneToReplay = "�x�y��";
    private void Awake()
    {
        uiReplay = GameObject.Find("���s").GetComponent<UIElement>();
        uiQuit = GameObject.Find("���}").GetComponent<UIElement>();

        uiReplay.onHandClick.AddListener((UnityAction) => { SceneManager.LoadScene(nameSceneToReplay); });
        uiQuit.onHandClick.AddListener((UnityAction) => { Application.Quit(); });
    }
}
