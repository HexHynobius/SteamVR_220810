using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private string nameBasketball = "²y";
    private TextMeshProUGUI textScore;
    private int addScore = 2;
    private int totoaScore;

    [SerializeField]
    GameObject ball;
    [SerializeField]
    GameObject player; 



    private void Awake()
    {
        textScore = GameObject.Find("¤À¼Æ").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name.Contains(nameBasketball))
        {
            AddScore();
            other.transform.position = player.transform.position;
        }
    }
    private void AddScore()
    {
        totoaScore += addScore;
        textScore.text = "SCORE\n" + totoaScore;
    }

    private void ChangeScore(int scoreToChange)
    {
        addScore = scoreToChange;
    }
}
