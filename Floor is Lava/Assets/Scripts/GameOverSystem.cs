using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSystem : MonoBehaviour
{

    private void Update()
    {
        ExistApp();
    }
    public void QuitApplicationButton()
    {
        Application.Quit();

    }

    public void PlayAgainButton()
    {
        SceneManager.LoadScene(0);
    }

    public void ExistApp()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                // Insert Code Here (I.E. Load Scene, Etc)
                // OR Application.Quit();
                Application.Quit();
                return;
            }
        }

    }
}
