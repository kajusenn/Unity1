using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    //[SerializeField] Transform trans;
    //Transform trans2;

    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite sprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
