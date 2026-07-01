using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 2f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.right);
        transform.Translate(speed * Time.deltaTime * transform.right, Space.World);

        //Vector2 dir = new(1f, 0f);
        //Vector2.right;
        //transform.right;
    }
}
