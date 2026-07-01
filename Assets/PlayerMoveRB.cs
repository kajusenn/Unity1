using UnityEngine;

public class PlayerMoveRB : MonoBehaviour
{
    Rigidbody2D rb;

    float moveSpeed = 5f;
    float dirX;

    bool isJumping = false;
    float jumptForce = 5f;

    private void Awake() => rb = GetComponent<Rigidbody2D>();
    
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");

        GetUserInput();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (dirX * moveSpeed, rb.linearVelocityY);

        Jump();
    }

    void GetUserInput()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    void Jump()
    {
        if (isJumping)
        {
            rb.linearVelocity += Vector2.up * jumptForce;
            isJumping = false;
        }
    }
}
