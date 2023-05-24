using UnityEngine;

namespace DefaultNamespace
{
    public class BulletCar1:MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Bullet1")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}