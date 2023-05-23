using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class ShootGun2 : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform carPrefab;
        float lastTime;
        void Update()
        {
            if (CarControl.isNormalControl)
            {
                if (Input.GetKeyDown(KeyCode.M))
                {
                    if (Time.realtimeSinceStartup - lastTime > 1f)
                    {
                        CreateBullet();
                        lastTime = Time.realtimeSinceStartup;
                    }
                }
            }

            else 
            {
                if (Input.GetKeyDown(KeyCode.V))
                {
                    if (Time.realtimeSinceStartup - lastTime > 1f)
                    {
                        CreateBullet();
                        lastTime = Time.realtimeSinceStartup;
                    }
                }
            }
        }

       void CreateBullet()
        {
            var pos = carPrefab.position;
            pos.x -= 6.5f;
            pos.y -= 1.5f;

            // Создание объекта пули
            GameObject bullet = Instantiate(bulletPrefab, pos, carPrefab.rotation);

            // Задание скорости пули
            bullet.GetComponent<Rigidbody2D>().velocity = -bullet.transform.right * 6;
        }
    }
}