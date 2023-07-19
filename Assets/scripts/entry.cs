using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entry : MonoBehaviour
{
    public GameObject ballF;
    public GameObject rain1;
    MeshRenderer renderer;
    MeshRenderer rainRenderer;
    Rigidbody Body;
    Rigidbody rBody;
  

      void Start()
    {
        
        renderer = ballF.GetComponent<MeshRenderer>();
        rainRenderer = rain1.GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rainRenderer.enabled = false;
        Body = ballF.GetComponent<Rigidbody>();
        rBody = rain1.GetComponent<Rigidbody>();
        Body.useGravity = false;
        rBody.useGravity = false;
    
    }
     private void OnTriggerEnter(Collider other) 
    {
        
        //change to red on collision 
        if(other.gameObject.tag == "Player")
        {

            RenderObject();
          
        }
        
    }

    void RenderObject()
    {
           Debug.Log("enter");
           renderer.enabled = true;
            Body.useGravity = true;
            rainRenderer.enabled = true;
            rBody.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
