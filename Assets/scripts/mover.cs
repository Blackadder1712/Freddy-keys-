using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
   public GameObject player;
   public GameObject head;
  float moveSpeed = 10f;
  float nitro = 15f;
  [SerializeField] float mainThrust = 100f; //speed



  //rotare 
  
  Rigidbody rb;
  

     
    
    [SerializeField] ParticleSystem mainParticles; //booster

   

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
      
    
        player = GameObject.Find("Player");
       
        head = GameObject.Find("Player/Fred_heads");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        ProcessThrust();

        void Movement()//player movement 
        {
            float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed; 
            float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;

            transform.Translate(xValue,0, zValue);        
            //move position with controller , framerate independent at selected speed
        }

       
        
        void ProcessThrust()
        {
            SpaceBar();
           
        }

        void SpaceBar()
        {
            if(Input.GetKey(KeyCode.Space))
            {
              
              Speed();
                if(!mainParticles.isPlaying)
                    {
                    mainParticles.Play();
                    } 
            }
            else
            {
                mainParticles.Stop();
            }
        }

        void Speed()
        {
            float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*nitro; 
            float zValue = Input.GetAxis("Vertical")*Time.deltaTime*nitro;

            transform.Translate(xValue,0, zValue);    
            
            //move position with controller , framerate independent at selected speed

        }


      

     
       
    }

        /*private void OnCollisionEnter(Collision other) 
    {
        //change to red on collision 
        if(other.gameObject.tag == "Untagged" )
        {
      
       
        
            if(!crash.isPlaying)
            {
                crash.Play();
            }       
                 
        }
        else
        {
            crash.Stop();
        */
    }

 

  
  
      

 


  

    

    

