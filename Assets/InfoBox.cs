using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoBox : MonoBehaviour
{
    [SerializeField] TMP_Text infoText;
    void Start()
    {
        Debug.Log(infoText.text);
        infoText.text = "HELLO MEN!";
    }
}
