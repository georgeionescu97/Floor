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
    GameOverSystem system;
    bool isJumpButtonPressed;
    

    

    [SerializeField] private FixedJoystick _fixedJoystick;

    void Start()
    {
        isJumpButtonPressed = false;
        system = FindObjectOfType<GameOverSystem>();
        isFirstCollides = false;
        isInTheAir = false;
        rb = GetComponent<Rigidbody>();
        score = GetComponent<ShowingScore>();
        isJumping = false;
    }

    private void FixedUpdate()
    {
        MovingPlayer();  
    }
    void Update()
    {
        
        
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
    
    void MovingPlayer()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //Vector3 move = new Vector3(horizontal, 0, vertical);
        //rb.AddForce(move * addingPower);

        Vector3 move = new Vector3(_fixedJoystick.Horizontal, 0, _fixedJoystick.Vertical);
        rb.AddForce(move * addingPower);

        if(isJumping)
        {
            
                rb.AddForce(-Vector3.up * gravityValue, ForceMode.Impulse);

        }

    }
    public void JumpButton()
    {
        StartCoroutine(IgnoreCollision());
        if (!isJumping)
        {
            
            isJumping = true;
            isInTheAir = true;
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);

            // gameObject.transform = floor3.transform.FindChild("Player");
            gameObject.transform.parent = null;
            //isJumpButtonPressed = false;
        }
    }
    
    IEnumerator IgnoreCollision()
    {
        this.gameObject.layer = LayerMask.NameToLayer("IgnoreCollision");
        yield return new WaitForSeconds(0.2f);
        this.gameObject.layer = LayerMask.NameToLayer("Player");
    }
   

}

