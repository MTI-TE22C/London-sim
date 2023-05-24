using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    
    public Rigidbody2D rb;
    public Animator animator;

    public bool Höger;
    public bool Vänster;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if (Input.GetKey("d") == true)
        {
            Höger = true;
            Vänster = false;
        }
        if (Input.GetKey("a") == true)
        {
            Höger = false;
            Vänster = true;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
