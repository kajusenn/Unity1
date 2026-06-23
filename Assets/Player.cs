using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] List<string> cars;

    void Start()
    {
        foreach (string car in cars)
        {
            Debug.Log(car);
        }
    } 

    void Update()
    {

    }
}
