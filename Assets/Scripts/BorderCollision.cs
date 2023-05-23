using UnityEngine;

namespace DefaultNamespace
{
    public class BorderCollision:MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(collision.gameObject);
        }
    }
}