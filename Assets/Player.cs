using UnityEngine;

public class Player : MonoBehaviour
{
    //private int attack = 10;
    //public int health = 15;
    //[SerializeField] private int speed = 10;
    //[SerializeField] Sprite gun;
    float num = 0;
    float my = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        num = Mathf.Repeat(Time.time, 10f);
        Debug.Log(num);

        my += 1;
        my = Mathf.Repeat(my, 5f);
        Debug.Log(my);
        Debug.Log("-----------");

    }
}
