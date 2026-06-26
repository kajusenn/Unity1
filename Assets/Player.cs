using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    IEnumerator myFade;


    void Start()
    {
        myFade = Fade();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(myFade);
        }

        if (Input.GetMouseButtonDown(1))
        {
            StopCoroutine(myFade);
        }
    }

    IEnumerator Fade()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.color = Color.white; //NOT WORK FROM COURSE
        Color32 c32 = spriteRenderer.color;

        for (int i = 255;i >= 0;i--)
        {
            yield return new WaitForSeconds(0.02f);
            spriteRenderer.color = new Color32(c32.r, c32.g, c32.b, (byte)i);
        }
    }
}