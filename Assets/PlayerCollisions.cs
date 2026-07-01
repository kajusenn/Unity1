using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.name);

        if(collision.gameObject.TryGetComponent<HP>(out HP hp))
        { 
            //Debug.Log(collision.gameObject.name);
            hp.TakeDamage();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
