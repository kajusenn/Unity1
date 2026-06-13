using UnityEngine;

public class Player : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //overpower functions (two functions with the same parameters)
        //Debug.Log(Power(5)); //take int
        //Debug.Log(Power(2f)); //take float

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log((int)Time.time % 4);

    }

    int Power(int num)
    {
        int result = num *= num;
        return result;
    }

    float Power(float num)
    {
        float result = num *= num;
        return result;
    }
}
