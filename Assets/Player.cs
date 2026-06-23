using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    [SerializeField] Transform trans;
    Transform trans2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
