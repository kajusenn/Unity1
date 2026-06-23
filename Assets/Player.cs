using UnityEngine;

public class Player : MonoBehaviour
{
    int hp = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(hp != 0)
            {
            hp -= 1;
            Debug.Log("-1HP");
            Debug.Log($"Health: {hp}");
            CheckHealth();
            }
            else
            {
                Debug.Log("YOU ARE DEAD");
            }
        }

    }

    void CheckHealth()
    {
        if (hp > 6)
        {
            //game green
            Debug.Log("Green");
        }
        else if (hp > 2)
        {
            //game orange
            Debug.Log("Orange");
        }
        else if (hp >= 1)
        {
            //game red
            Debug.Log("Red");
        }
        else
        {
            //dead
            Debug.Log("DEAD");
        }
    }
}
