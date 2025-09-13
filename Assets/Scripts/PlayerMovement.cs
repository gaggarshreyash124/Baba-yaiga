using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Component Refrences
    Rigidbody2D rb;

    //Check Variables
    public Transform groundCheck;

    // Movement Variables
    public float speed = 5f;
    public float Jumpforce = 10f;

    // Check if the player is grounded
    public LayerMask groundLayer;

    public bool isGrounded()
    {
        return Physics2D.Raycast(groundCheck.transform.position, Vector2.down, 1.1f);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        Debug.Log(isGrounded());
    }
}
