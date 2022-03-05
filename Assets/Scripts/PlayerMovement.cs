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
    public bool isGrounded;
    bool isCrouching = false;

    public Enemy enemy;

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

        if (isGrounded)
        {
            enemy.ChasePlayer();
        }
        else
        {
            enemy.Patroling();
        }
      




        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);







        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);



    }
  
}
