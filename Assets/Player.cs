using UnityEngine;

public class Player : MonoBehaviour
{
    //Vector3 pos = new Vector3(1f, 2f, 3f);
    //Vector3 pos = new(0f, 0f 0f);
    [SerializeField] Transform enemy;

    void Start()
    {
        //transform.position = Vector3.zero;
    }

    void Update()
    {
        //transform.position += Vector3.right;
        transform.position = Vector3.MoveTowards(transform.position, enemy.position, Time.deltaTime);
    }
}
