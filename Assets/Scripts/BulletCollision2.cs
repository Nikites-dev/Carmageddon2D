using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

namespace DefaultNamespace
{
    public class BulletCollision2:MonoBehaviour
    {
        public int carHP = 100;
        private Random random = new Random();
        [SerializeField] private GameObject txtHP;
        [SerializeField] private GameObject car1Prefab;
        [SerializeField] private GameObject loseGamePrefab;
        [SerializeField] private GameObject textWin;
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag != "Train")
            {
                int numRndx = random.Next(-8, -3); 
                int numRndy = random.Next(-2, 3); 
                car1Prefab.GetComponent<Rigidbody2D>().velocity = new Vector3(numRndx, numRndy, 0);
            
                carHP-= 5;

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
                textWin.GetComponent<Text>().text = "Player 2";
                Time.timeScale = 0f;
            }
        }
    }
}