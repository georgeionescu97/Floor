using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameOverCollision : MonoBehaviour
{

    public Transform playerTransform;
    public GameObject player;
    [SerializeField] ParticleSystem destroyedParticle;
    DestroyPlayer destroyPlayer;


    private void Start()
    {
        
    }
    void Update()
    {
        transform.position = new Vector3(0, -50, playerTransform.transform.position.z);
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
        {
            destroyedParticle.Play();
            player.GetComponent<DestroyPlayer>().DestroingPlayer();
        }
    }
}
