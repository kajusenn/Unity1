using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public int Hp { get; private set; }

    //int hp = 10;

    //public int Hp
    //{
    //    get {
    //        return hp;
    //    }
    //    set
    //    {
    //        hp = value;
    //    }
    //}

    [field:SerializeField] public int Hp {
        get; private set;
    }

    void Start()
    {
        
    }


    void Update()
    {

    }
}