using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    
   

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(0).Rotate(0f, 0, 0.6f);
    }

}
