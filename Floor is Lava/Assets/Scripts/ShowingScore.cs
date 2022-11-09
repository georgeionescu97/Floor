using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowingScore : MonoBehaviour
{
    int _score;
    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {
        _score = 0;
    }
    private void Update()
    {
        scoreText.text = _score.ToString();
    }

    public void DisplayScoreBrownSquare()
    {
        _score += 300;
    }
    public void CoinsCollision()
    {
        _score += 100;
    }
   
}
