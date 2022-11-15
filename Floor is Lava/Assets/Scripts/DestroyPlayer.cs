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
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        
        yield return new WaitForSeconds(2f);
        
        SpawningPlaces();
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);

    }
    void SpawningPlaces()
    {
        if (transform.position.z < spawnPoint2.position.z)
        {
            transform.position = spawnPoint0.position;
        }
        else if (transform.position.z < spawnPoint3.position.z && transform.position.z > spawnPoint1.position.z) 
        {
            transform.position = spawnPoint1.position;
        }
        else if(transform.position.z > spawnPoint3.position.z && transform.position.z < spawnPoint4.position.z)
        {
            transform.position = spawnPoint3.position;
        }
        else if(transform.position.z > spawnPoint4.position.z) 
        {
            transform.position = spawnPoint4.position;
        }
        
    }
}
