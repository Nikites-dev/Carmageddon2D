
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

namespace DefaultNamespace
{
    public class BulletCollision: MonoBehaviour
    {
        public int carHP = 100; 
        private Random random = new Random();
        
         [SerializeField] private GameObject txtHP;
         [SerializeField] private GameObject car2Prefab;
         [SerializeField] private GameObject loseGamePrefab;
         [SerializeField] private GameObject textWin;
         
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag != "Train")
            {
                double numRndx = - random.NextDouble() * (0.9 - 0) + 0; 
                double numRndy =  - random.NextDouble() * (0.5 - 0) + 0; 
                car2Prefab.GetComponent<Rigidbody2D>().velocity = new Vector3( (float)numRndx, (float)numRndy, 0);
                
                carHP--;

                txtHP.GetComponent<Text>().text = carHP.ToString();
                Destroy(collision.gameObject);    
            }
            else
            {
                carHP -= 20;
                txtHP.GetComponent<Text>().text = carHP.ToString();
            }

            if (carHP < 1)
            {
                loseGamePrefab.SetActive(true);
                textWin.GetComponent<Text>().text = "Player 1";
                Time.timeScale = 0f;
            }

        }
        
        
    }
    
    
}