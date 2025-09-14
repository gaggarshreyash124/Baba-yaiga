using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Component Refrences
    //Rigidbody2D rb;

    //Check Variables
    public Transform groundCheck;

    // Movement Variables
    public float speed = 5f;
    public float Jumpforce = 10f;
    private float velocity;
    float Gravity = -9.8f;

    // Check if the player is grounded
    public LayerMask groundLayer;

    public bool isGrounded()
    {
        return Physics2D.Raycast(groundCheck.transform.position, Vector2.down, 0.1f,groundLayer);
    }
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        velocity += Gravity * Time.deltaTime;

        if (isGrounded())
        {
            if (Input.GetKey(KeyCode.Space))
            {
                velocity = Jumpforce;
            }
            else
            {
                if (velocity < 0)
                {
                    velocity = 0;
                }
            }
        }

    }

    private void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, 0,0);
        transform.position = new Vector2(transform.position.x, transform.position.y + velocity * Time.deltaTime);

        Debug.Log(isGrounded());

    }
        
        
    }

    

