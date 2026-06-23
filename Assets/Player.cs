using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //List<string> cars = new();
    [SerializeField] List<string> cars = new();

    void Start()
    {
        cars.Add("Audi");
        cars.Add("Honda");
        Debug.Log(cars[0]);

        cars.RemoveAt(1);
        Debug.Log(cars.Count);
    } 

    void Update()
    {

    }
}
