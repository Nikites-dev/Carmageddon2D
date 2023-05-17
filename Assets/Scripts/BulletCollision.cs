
using UnityEngine;

namespace DefaultNamespace
{
    public class BulletCollision: MonoBehaviour
    {
         // [SerializeField] private GameObject bulletPrefab;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(collision.gameObject);
            // bulletPrefab.
        }
    }
}