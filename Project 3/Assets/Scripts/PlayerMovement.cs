using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This Script creates Player Movement, as well as Jumping, Crouching and Sprinting
public class PlayerMovement : MonoBehaviour
{
    //allows referencing of gameobjects, components and transforms.
    public CharacterController controller;
    public Transform groundCheck;
    public LayerMask groundMask;
    public GameObject player;

    //creates floats for ground distance, speed, gravity and jumpheight
    public float groundDistance = 0.4f;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    //creates a vector3 for velocity
    Vector3 velocity;
    //creates a true/false for if the player is on the ground
    bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed /= 2;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            player.transform.localScale = new Vector3(1.2f, .9f, 1.2f);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            player.transform.localScale = new Vector3(1.2f, 1.8f, 1.2f);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
