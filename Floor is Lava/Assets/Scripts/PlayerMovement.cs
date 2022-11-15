using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
   public float jumpAmount = 60f;
   public float addingPower = 20;
    bool isJumping;
    bool isInTheAir;
    bool isFirstCollides;
    
    public float gravityValue = .5f;
    public GameObject floor;
    [SerializeField] ParticleSystem explosionParticles;
    ShowingScore score;
    public Transform floor3;
    GameOverCollision collision;


    void Start()
    {
        isFirstCollides = false;
        isInTheAir = false;
        rb = GetComponent<Rigidbody>();
        score = GetComponent<ShowingScore>();
    }

    void Update()
    {
        MovingPlayer();
        JumpingPlayer();
    }

    private void OnCollisionEnter(Collision other)
    {
            if (other.gameObject.tag == "Floor" && isJumping)
            {
                if (isFirstCollides)
                {
                isFirstCollides = false; 
                isJumping = false;
                isInTheAir = false;
                }
                else
                {
                isJumping = false;
                isInTheAir = false;
                score.LosingScore();
                }
            }
 
        if (other.gameObject.tag == "Brown Plane" && isInTheAir)
        {
            isJumping = false;
            explosionParticles.Play();
            isInTheAir = false;
            score.DisplayScoreBrownSquare();
            Destroy(other.gameObject);

        }
        else if (other.gameObject.tag == "Blue Plane" && isInTheAir)
        {
            Debug.Log("Albastru");
            isJumping = false;
            explosionParticles.Play();
            isInTheAir = false;
            score.DisplayScoreBrownSquare();
            Destroy(other.gameObject);

        }
    }
    public bool isFirstCollideswithFloor()
    {
        return isFirstCollides = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin" && isInTheAir)
        {
            isJumping = false;
            explosionParticles.Play();
            isInTheAir = false;
            score.CoinsCollision();
            Destroy(other.gameObject);
        }
    }
    void JumpingPlayer()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            isInTheAir = true;
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);

           // gameObject.transform = floor3.transform.FindChild("Player");
            gameObject.transform.parent = null;
            
        }
        else
        {
            rb.AddForce(-Vector3.up * gravityValue, ForceMode.Impulse);
            
        } 
    }
    void MovingPlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, 0, vertical);
        rb.AddForce(move * addingPower);
    }
}

