using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public Transform spawnPoint0;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;

    private void Start()
    {
        
      
    }
    public void DestroingPlayer()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        
        yield return new WaitForSeconds(2f);
        SpawningPlaces();
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    void SpawningPlaces()
    {
        if (transform.position.z < 50)
        {
            transform.position = spawnPoint0.position;
        }
        else if (transform.position.z > 50 && transform.position.z < 90) 
        {
            transform.position = spawnPoint1.position;
        }
        else if(transform.position.z > 90 && transform.position.z < 140)
        {
            transform.position = spawnPoint2.position;
        }
        else if(transform.position.z > 140)// (...&& transform.position.z < 170) 
        {
            transform.position = spawnPoint3.position;
        }
        
    }
}
