using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceScoreScript : MonoBehaviour
{

    public GameObject StartPos;
    public TextMeshProUGUI scoreText;
    public GameObject ScoreTextObj;

    public TextMeshProUGUI EndScoreText;
    

    private float distance;

    void Start()
    {
        scoreText = ScoreTextObj.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        distance = (StartPos.transform.position.x + this.transform.position.x);
        scoreText.text = distance.ToString("F1") + "M";

        EndScoreText.text = distance.ToString("F1") + "M";
    }
}
