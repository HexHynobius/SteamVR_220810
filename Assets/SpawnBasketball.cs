using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SpawnBasketball : MonoBehaviour
{
    [SerializeField, Header("籃球預置物")]
    private GameObject goBasketball;

    private UIElement btnSpawnBasketball;
    private Transform traPlayer;
    private void Awake()
    {
        traPlayer = GameObject.Find("Player").transform;
        btnSpawnBasketball = GameObject.Find("生成籃球").GetComponent<UIElement>();

        btnSpawnBasketball.onHandClick.AddListener((x) =>
        {
            Vector3 posBall = traPlayer.position + traPlayer.forward*0.6f + traPlayer.up;
            Instantiate(goBasketball, posBall, Quaternion.identity);
        });

    }
}
