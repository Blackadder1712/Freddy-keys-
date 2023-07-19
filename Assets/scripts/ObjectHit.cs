using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
  
    public GameObject player;
    
      bool collisionDisable = false; // turn collidors on and off 
  

      void Start()
      {
         player = GameObject.Find("Player");
     
        
      }
  
    private void OnCollisionEnter(Collision other) 
    {
        //change to red on collision 
        if(other.gameObject.tag == "Player" && gameObject.tag =="Untagged")
        {
            
            gameObject.tag = "hit";
          
                 
        }

          if(other.gameObject.tag == "Player" && gameObject.tag =="collect")
        {
            
           Debug.Log("yes");
                 
        }


       
    }

    private void OnCollisionExit(Collision other) 
    {
             if(Input.GetKeyDown(KeyCode.C))
        {
                collisionDisable = !collisionDisable; //toggle collision
        }
    }

        void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.C))
        {
                collisionDisable = !collisionDisable; //toggle collision
        }

    }

}
