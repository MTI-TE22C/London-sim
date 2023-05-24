using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    
    public Rigidbody2D rb;
    public Animator animator;

    public bool H�ger;
    public bool V�nster;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if (Input.GetKey("d") == true)
        {
            H�ger = true;
            V�nster = false;
        }
        if (Input.GetKey("a") == true)
        {
            H�ger = false;
            V�nster = true;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
