using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class BulletCollision2:MonoBehaviour
    {
        public int carHP = 100; 
        
        [SerializeField] private GameObject txtHP;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            carHP-= 5;

            txtHP.GetComponent<Text>().text = carHP.ToString();
            Destroy(collision.gameObject);
        }
    }
}