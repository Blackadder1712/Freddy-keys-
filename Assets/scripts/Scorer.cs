using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //restarting/loading scene

public class Scorer : MonoBehaviour
{
    [SerializeField] float levelLoadDelay;
    
      AudioSource dead;
     [SerializeField]  AudioClip jump;
         [SerializeField]  AudioClip eat;
      AudioSource scare;
    
     AudioSource crash;
     AudioSource Keypick;
     [SerializeField] AudioClip KeyUp;
     AudioClip ouch;
      AudioSource yum;
    [SerializeField] ParticleSystem ExplodeParticles; //explosion effects 
     [SerializeField] ParticleSystem BigExplodeParticles; //explosion effects 
    int hits = 0; //hold number of hits 
    int pizzas = 0;
      bool collisionDisable = false; // turn collidors on and off 
      bool pickUpDisable = false;
      MeshRenderer renderer;

    
  

    void Start()
    {
      crash = GetComponent<AudioSource>();
       dead = GetComponent<AudioSource>();   
       scare =GetComponent<AudioSource>();
       yum = GetComponent<AudioSource>();
      renderer = GetComponent<MeshRenderer>();

  
       Keypick = GetComponent<AudioSource>();
   
   
    
    
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Untagged" && !collisionDisable) //|| collisionDisable)
        {    
         hit();

        }

          if(other.gameObject.tag == "collect" && !collisionDisable)
        {
          pizza();
        }

           
        if(!pickUpDisable)
        {
              
        }


              if(other.gameObject.tag == "keys" )
        {
            Debug.Log("gotem");
            Keys();
        }
        
     
     

    

        if(hits >= 5)
        {
             StartCrashSequence();// 1 sec delay
           
        }

        
    }



    
 


      
    void hit() 
    {
          hits++; //each hit adds 1 to variable 
      
              ExplodeParticles.Play();    
              
            if(!crash.isPlaying)
            {
                crash.Play();
            }       
    }

    void pizza() 
    {
          pizzas++; //each hit adds 1 to variable 
            Debug.Log("You've collected this many pizzas:" + pizzas);//display value 
            renderer.enabled = false;

            

                if(!yum.isPlaying)
            {
                 yum.PlayOneShot(eat);
            }         
          
             
              
    }

    void Keys()
    {
       

         if(!Keypick.isPlaying)
            {
                 Keypick.PlayOneShot(KeyUp);
            }   
      
    }

  

        void RestartLevel()//reloads level on fail 
    {
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//return index of current scene
    }

        void StartCrashSequence()
    {
       scare.PlayOneShot(jump);
         BigExplodeParticles.Play();
        GetComponent<mover>().enabled = false;//remove control
         Invoke("RestartLevel", levelLoadDelay);

    }

    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.C))
        {
                collisionDisable = !collisionDisable; //toggle collision
        }

          if(pizzas == 7 )
        {
                pickUpDisable = !pickUpDisable; //toggle collision
        }

    }

}
