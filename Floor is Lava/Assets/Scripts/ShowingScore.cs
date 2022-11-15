using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowingScore : MonoBehaviour
{
    public int _score;
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
        _score += 200;
    }
    public void CoinsCollision()
    {
        _score += 100;
    }
    public void LosingScore()
    {
        if(_score > 0)
        {
            _score -= 50;
        }
            
    }
    public int Score()
    {
        return _score;
    }
   
}
