using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;



    public float speed;
    public float SprintSpeed = 24f;
    public float WalkSpeed = 12;
    public float CrouchSpeed = 6;

    

    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMaks;


    Vector3 velocity;
    bool isGrounded;
    bool isCrouching = false;

    void Start()
    {
       

        speed = WalkSpeed;







    }
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMaks);
       

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //Sprint
        if (Input.GetKeyDown(KeyCode.LeftShift)&& isGrounded)
        {
            speed = SprintSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = WalkSpeed;
        }

        //Crouch
        if (Input.GetKeyDown(KeyCode.C))
        {
            isCrouching = !isCrouching;

            if (isCrouching == true)
            {
                controller.height = 2f;
                speed = CrouchSpeed;
                SprintSpeed = SprintSpeed / 2;
            }
            else
            {
                controller.height = 4;
                speed = WalkSpeed;
                SprintSpeed = SprintSpeed *2;
            }
        }


        
      


            velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
       


    }

  
}
