using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform aim;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, aim.position, aim.rotation);
    }
}
