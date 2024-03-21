using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientodeljugador : MonoBehaviour
{


    public CharacterController characterController;


    public float speed = 12f; 

    private float gravity = -9.81f; 



    public Transform groundCheck;
    public float sphereRadius = 0.3f;
    public LayerMask groundMask;


    bool isGrounded; 


    
    Vector3  velocity;

    public float jumpHeight = 3;


    



    void Update()
    {
      
        isGrounded = Physics.CheckSphere(groundCheck.position,sphereRadius,groundMask); 


        if  (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); 
        
        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime); 



        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)  
        {
            velocity.y = Mathf.Sqrt(jumpHeight  * -2 * gravity);   

        }

        
        characterController.Move(velocity * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime); 








    }
}


