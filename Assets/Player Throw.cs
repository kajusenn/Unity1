using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    [SerializeField] GameObject throwPrefab;
    [SerializeField] Transform aim;
    [SerializeField] Vector2 dir;

    bool isThrowing = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            isThrowing = true;
        }
    }

    private void FixedUpdate()
    {
        if(isThrowing)
        {
            Throw();
            isThrowing = false;
        }
    }

    void Throw()
    {
        GameObject item = Instantiate(throwPrefab, aim.position, Quaternion.identity);
        item.GetComponent<Rigidbody2D>().AddForce(dir, ForceMode2D.Impulse);
    }
}
