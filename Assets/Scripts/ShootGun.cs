using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace
{
    public class ShootGun:MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform carPrefab;
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                // Создание объекта пули
                GameObject bullet = Instantiate(bulletPrefab, carPrefab.position, carPrefab.rotation);

               
                
                // Задание скорости пули
                bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * 6;
                
                
                
            }
        }
    }
}