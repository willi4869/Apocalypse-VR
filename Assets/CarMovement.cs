using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 moveDirection;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;
    public float gravity = -9.81f;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // if (isGrounded && velocity.y < 0)
        // {
        //     velocity.y = -2f;
        // }

        // velocity.y += gravity * Time.deltaTime;

        // Vector3 a = transform.position;
        // Vector3 b = target.position;
        // transform.position = Vector3.Lerp(a, b, speed);
        transform.Translate(moveDirection, Space.World);
    }
}
