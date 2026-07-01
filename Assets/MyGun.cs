using NUnit.Framework;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MyGun : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform aim;

    List<GameObject> ammoPool = new List<GameObject>();

    GameObject bullet;

    void CreatePool()
    {
        for (int i = 0;i < 20;i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            ammoPool.Add(bullet);
        }
    }

    GameObject GetBullet()
    {
        for (int i = 0;i < ammoPool.Count;i++)
        {
            if (!ammoPool[i].activeInHierarchy)
            {
                return ammoPool[i];
            }
        }

        return null;
    }

    void Shoot()
    {
        bullet = GetBullet();
        bullet.transform.position = aim.position;
        bullet.transform.localRotation = aim.rotation;
        bullet.SetActive(true);

    }

    void Start()
    {
        CreatePool();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
}
