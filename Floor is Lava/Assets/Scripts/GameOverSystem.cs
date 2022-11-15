using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSystem : MonoBehaviour
{
  
   
    public void QuitApplicationButton()
    {
        Application.Quit();

    }

     public void PlayAgainButton()
    {
        SceneManager.LoadScene(0);
    }
}
