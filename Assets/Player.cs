using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //string[] arr = { "Meg", "Zara", "Bob", "Greg", "Martin", "Elon", "Jan" };
    //List<int> list1 = new();

    void Start()
    {
        //Array.Sort(arr);
        //Array.Reverse(arr);

        //foreach (var item in arr)
        //{
        //    Debug.Log(item);
        //}


        //list1.Add(12);
        //list1.Add(8);
        //list1.Add(3);
        //list1.Add(22);
        //list1.Add(36);
        //list1.Add(1);

        //list1.Sort();
        //list1.Reverse();

        //foreach (var item in list1)
        //{
        //    Debug.Log(item);
        //}


        //ALONE TASK:
        int many = 10;

        int[] arr = new int[many + 1];

        for (int i = 0;i <= many;i++)
        {
            int rnd = UnityEngine.Random.Range(0, 11);

            arr[i] = rnd;
        }

        Array.Sort(arr);

        for (int i = 0;i < arr.Length;i++)
        {
            Debug.Log($"{i}. {arr[i]}");
        }
    }


    void Update()
    {

    }
}