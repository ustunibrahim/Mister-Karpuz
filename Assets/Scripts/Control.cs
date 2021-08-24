using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Control : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft, moveRight;
    private float horizontalMove;
    public float speed = 50, jumpSpeed = 100;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
    }
    public void PointerDownLeft()
    {
        moveLeft = true;
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }


    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }

    void Update()
    {
        MomentPlayer();   
    }
    private void MomentPlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
        }
        else if(moveRight)
        {
            horizontalMove = speed;
        }
        else
        {
            horizontalMove = 0;
        }
    }

    public void jumpButton()
    {
        if (rb.velocity.y == 0)
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

}