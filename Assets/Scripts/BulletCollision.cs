
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class BulletCollision: MonoBehaviour
    {
        public int carHP = 100; 
        
         [SerializeField] private GameObject txtHP;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag != "Train")
            {
                carHP--;

                txtHP.GetComponent<Text>().text = carHP.ToString();
                Destroy(collision.gameObject);    
            }
            else
            {
                carHP -= 20;
                txtHP.GetComponent<Text>().text = carHP.ToString();
            }
            
        }
        
        
    }
    
    
}