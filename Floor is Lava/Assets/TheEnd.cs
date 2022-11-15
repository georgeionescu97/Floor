using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TheEnd : MonoBehaviour
{

    public GameObject endFloor;
    public Canvas finishCanvas;
    ShowingScore score;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        finishCanvas.enabled = false;
        score = FindObjectOfType<ShowingScore>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == endFloor)
        {
            Time.timeScale = 0;
            finishCanvas.enabled = true;
            score.Score();
            scoreText.text = "Your score was: " + score.Score().ToString(); 
            
        }
    }
}
