using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int randNum = Random.Range(0, 11);
        Debug.Log(randNum);

    }

    // Update is called once per frame
    void Update()
    {
        float randNumFloat = Random.Range(0f, 11f);
        Debug.Log(randNumFloat);
    }
}
