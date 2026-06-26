using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class DiceRotation : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] List<Sprite> renderers;
    byte howManyElements = 5;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            int rnd = Random.Range(0, howManyElements + 1);
            Debug.Log(rnd);
            StartCoroutine(Change(rnd));
        }
    }

    IEnumerator Change(int rnd)
    {
        for (int i = 0;i <= howManyElements;i++)
        {
            float rndColor1 = Random.Range(0f, 256f);
            float rndColor2 = Random.Range(0f, 256f);
            float rndColor3 = Random.Range(0f, 256f);
            spriteRenderer.color = new Color32((byte)rndColor1, (byte)rndColor2, (byte)rndColor3, 255);

            yield return new WaitForSeconds(0.5f);
            spriteRenderer.sprite = renderers[i];
        }

        yield return new WaitForSeconds(0.001f);

        spriteRenderer.sprite = renderers[rnd];
        spriteRenderer.color = Color.limeGreen;
    }
}
