using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement
    public float moveSpeed;
    Rigidbody2D rigidBody;
    Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManagment();
    }

    void FixedUpdate()
    {
        Move();
    }

    void InputManagment()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX,moveY).normalized;
    }

    private void Move()
    {
        rigidBody.velocity = new Vector2 (moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
