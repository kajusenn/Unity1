using UnityEngine;

public class Player : MonoBehaviour
{
    //string[] names = { "John", "Ann", "Mark" };
    [SerializeField] Color32[] colors;

    void Start()
    {
        //Debug.Log(names[0]);
        //names[0] = "Adam";
        //Debug.Log(names[0]);
        int rnd = Random.Range(0, colors.Length);
        GetComponent<SpriteRenderer>().color = colors[rnd];

    } 

    void Update()
    {

    }
}
