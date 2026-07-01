using UnityEngine;

public class PlayerMoveRB : MonoBehaviour
{
    Rigidbody2D rb;

    float moveSpeed = 5f;
    float dirX;

    bool isJumping = false;
    float jumptForce = 5f;

    private void Awake() => rb = GetComponent<Rigidbody2D>();

    int lastDirX = 0;
    
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");

        GetUserInput();

        RotatePlayer();
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

        //Input.GetKeyDown(KeyCode.Space);
        //Input.GetMouseButtonDown(1);
    }

    void Jump()
    {
        if (isJumping)
        {
            rb.linearVelocity += Vector2.up * jumptForce;
            isJumping = false;
        }
    }

    void RotatePlayer()
    {
        if(lastDirX != (int)dirX){
            if (dirX == 0) 
                return;
            int rotY = dirX > 0 ? 0 : 180;
            transform.localRotation = Quaternion.Euler(0f, rotY, 0f);
            lastDirX = (int)dirX;

            //int rotY;
            //if(dirX > 0)
            //{
            //    rotY = 0;
            //}
            //else
            //{
            //    rotY = 180;
            //}
        }
    }
}
