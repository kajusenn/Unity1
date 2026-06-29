using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class InfoBox : MonoBehaviour
{
    [SerializeField] TMP_Text infoText;

    [SerializeField] TMP_Text randomNumber;
    [SerializeField] Button randomBtn;

    [SerializeField] TMP_Text m_Text;
    [SerializeField] TMP_Text m_TextCorrect;
    [SerializeField] TMP_Text m_TextRecord;
    [SerializeField] TMP_InputField m_InputField;

    [SerializeField] Slider volumeSlider;
    [SerializeField] TMP_Text volumeText;
    [SerializeField] AudioSource audioSource;
    [SerializeField] Image[] speaker;

    string replay;
    int rightAns = 0;
    int record = 0;


    void Start()
    {
        //Debug.Log(infoText.text);
        //infoText.text = "HELLO MEN!";
        //randomBtn.onClick.AddListener(() => RandomNum());

        randomBtn.onClick.AddListener(delegate { RandomNum(); });
        RandomNum();
    }

    private void Update()
    {
        infoText.text = Time.time.ToString("F0");
    }

    public void RandomNum()
    {
        //int rnd = Random.Range(0, 101);
        //randomNumber.text = rnd.ToString();

        int rnd1 = UnityEngine.Random.Range(0, 11);
        int rnd2 = UnityEngine.Random.Range(0, 11);

        int task = rnd1 + rnd2;

        randomNumber.text = $"{rnd1} + {rnd2}";

        replay = task.ToString();
    }

    public void CollectInput()
    {

        if (m_InputField.text == replay)
        {
            m_Text.text = "YEAH!";
            if(rightAns == record)
            {
                record++;
            }
            rightAns++;

            m_TextCorrect.text = $"Good Answers: {rightAns}";
            m_TextRecord.text = $"Record: {record}";
            RandomNum();
        }
        else
        {
            m_Text.text = "BAD!";
            rightAns = 0;
            m_TextCorrect.text = $"Good Answers: {rightAns}";
            m_TextRecord.text = $"Record: {record}";
        }
    }

    public void ChangeVolume()
    {
        volumeText.text = volumeSlider.value.ToString();
        audioSource.volume = volumeSlider.value / volumeSlider.maxValue;

        float currentVal = volumeSlider.value;

        speaker[0].enabled = currentVal >= 0;
        speaker[1].enabled = currentVal >= 25;
        speaker[2].enabled = currentVal >= 50;
        speaker[3].enabled = currentVal >= 90;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
