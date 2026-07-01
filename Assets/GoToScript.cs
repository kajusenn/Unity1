using System.Net;
using UnityEngine;

public class GoToScript : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 5;
    Vector2 dir;
    void Start()
    {
        dir = target.position - transform.position;
        Debug.Log(dir);
        Debug.Log(dir.magnitude);
        dir.Normalize();
        Debug.Log(dir);
        Debug.Log(dir.magnitude);
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * dir);
    }
}
