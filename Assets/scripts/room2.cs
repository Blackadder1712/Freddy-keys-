using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room2 : MonoBehaviour
{
    public GameObject secondRain;
    MeshRenderer renderer;
    Rigidbody Body;
    [SerializeField] float waitTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
        renderer = secondRain.GetComponent<MeshRenderer>();
        renderer.enabled = false;
        Body = secondRain.GetComponent<Rigidbody>();
        Body.useGravity = false;
    }

         private void OnTriggerEnter(Collider other) 
            {
                
                //change to red on collision 
                if(other.gameObject.tag == "Player")
                {
                    Debug.Log("enter2");
                    if(Time.time > waitTime)
                        {
                          DropObject();// render and place gravuty
                        }
                
                }

              
                
            }

               void DropObject()
                {
                     renderer.enabled = true;
                     Body.useGravity = true;
                }

    // Update is called once per frame
    void Update()
    {
       
    }
}
