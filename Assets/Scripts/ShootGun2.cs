using UnityEngine;

namespace DefaultNamespace
{
    public class ShootGun2:MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform carPrefab;
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                var pos = carPrefab.position;
                pos.x -= 6.5f;
                pos.y -= 1.5f;
                
                // Создание объекта пули
                GameObject bullet = Instantiate(bulletPrefab, pos, carPrefab.rotation);
                
                // Задание скорости пули
                bullet.GetComponent<Rigidbody2D>().velocity = - bullet.transform.right * 6;
            }
        }
    }
}