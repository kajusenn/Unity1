using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField] List<string> cars;

    void Start()
    {
        //for (int i = 0;i < cars.Count;i++)
        //{
        //    Debug.Log(cars[i]);
        //}

        //foreach (string car in cars)
        //{
        //    Debug.Log(car);
        //}

        //int i = 0;
        //while (i <= 1000)
        //{
        //    Debug.Log(i);
        //    i++;
        //}

        //TASK:
        //for (int i = 10;i <= 20;i++)
        //{
        //    if(i % 2 == 0)
        //    {
        //        Debug.Log(i);
        //    }
        //}


        //TASK 2:
        //string output = "";

        //for (int i = 10;i >= 0;i--)
        //{
        //    output += i;

        //    Debug.Log(output += ", ");
        //}


        //TASK 3:
        List<int> rndNum = new();

        for (int i = 0;i <= 20;i++)
        {
            int rnd = Random.Range(10, 21);
            rndNum.Add(rnd);

            //Debug.Log($"{i}: {rndNum[i]}");
            Debug.Log(rndNum[i]);
            //Debug.Log(i);

        }
    }


    void Update()
    {

    }
}