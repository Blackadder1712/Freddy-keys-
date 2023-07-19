using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform myGameObjectTransform;
    public float zAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
        rotate();

        void rotate()
            {
              
                Controls();
                           
            }

            void Controls() //face correct way
            {
                   if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                right();
                }

                if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                left();
                }

                  if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                {
                forward();
                }  

                  if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
                {
                back();
                }
              
            }

            void right()
            {
                this.transform.rotation = Quaternion.Euler(-90,0,90);
            }

            void left()
            {
               this.transform.rotation = Quaternion.Euler(-90,0,-90);
            }

            void forward()
            {
                 this.transform.rotation = Quaternion.Euler(-90,0,0);
            }

            void back()
            {
                this.transform.rotation = Quaternion.Euler(-90,0,180);
            }
    }
}
