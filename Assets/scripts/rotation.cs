using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
      Rigidbody rb ;
       [SerializeField] float rotateThrust = 100f;

       
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
           ProcessRotation();
    }

      void ProcessRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
           ApplyRotation(-rotateThrust);
        }

         else if(Input.GetKey(KeyCode.D))  //not going left and right at same time
        {
           ApplyRotation(rotateThrust);
        }
    }

        void ApplyRotation(float rotationThisFrame)
    {
         rb.freezeRotation =true; //stop natural rotation on collision
         transform.Rotate(Vector3.up * rotationThisFrame * Time.deltaTime);//rotate back
         rb.freezeRotation = false; //unfreezing rotation;
    }
}
