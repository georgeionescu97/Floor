using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesShowing : MonoBehaviour
{
    [SerializeField] private GameObject [] _image;
    int life;
    private bool dead;
    public Canvas gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.enabled = false;
        life = _image.Length;
        Time.timeScale = 1;
    }
    void Update()
    {
        if(dead == true)
        {
            gameOverCanvas.enabled = true;
            Time.timeScale = 0;
           // gameOverCanvas.
        }
    }
    public void LosingLives()
    {
        if(life >= 1)
        {
            life --;
            Destroy(_image[life].gameObject);
            if (life < 1)
            {
                StartCoroutine(WaitForGettingBack());
            }
        } 
    }

    IEnumerator WaitForGettingBack()
    {
        yield return new WaitForSeconds(2f);
        dead = true;
    }

}
