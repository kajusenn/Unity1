using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 dir; //dir = direction
    [SerializeField] float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        dir.Normalize();
        transform.Translate(moveSpeed * Time.deltaTime * dir);
    }
}
