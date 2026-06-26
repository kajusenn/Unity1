using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InfoBox : MonoBehaviour
{
    [SerializeField] TMP_Text infoText;
    [SerializeField] TMP_Text randomNumber;
    [SerializeField] Button randomBtn;

    void Start()
    {
        //Debug.Log(infoText.text);
        //infoText.text = "HELLO MEN!";
        //randomBtn.onClick.AddListener(() => RandomNum());
        randomBtn.onClick.AddListener(delegate {
            RandomNum(); });
    }

    private void Update()
    {
        infoText.text = Time.time.ToString("F0");

    }

    public void RandomNum()
    {
        int rnd = Random.Range(0, 101);

        randomNumber.text = rnd.ToString();
    }
}
