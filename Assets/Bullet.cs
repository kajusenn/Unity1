//using UnityEngine;

//public class Bullet : MonoBehaviour
//{
//    float speed = 2f;

//    void Update()
//    {
//        transform.Translate(speed * Time.deltaTime * Vector3.right);
//        transform.Translate(speed * Time.deltaTime * transform.right, Space.World);

//        //Vector2 dir = new(1f, 0f);
//        //Vector2.right;
//        //transform.right;
//    }
//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    int damage = 1;
    int speed = 30;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        rb.linearVelocity = transform.right * speed;
        rb.angularVelocity = 0;
        StartCoroutine(ReturnToPool(2f));
    }


    IEnumerator ReturnToPool(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(ReturnToPool(0f));
    }
}
