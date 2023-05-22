using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class BorderCar:MonoBehaviour
    {
        [SerializeField] private GameObject loseGamePrefab;
        [SerializeField] private GameObject textWin;

        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Car1")
            {
                loseGamePrefab.SetActive(true);
                textWin.GetComponent<Text>().text = "Player 2";
                Time.timeScale = 0f;
            }
            
            if (collision.gameObject.tag == "Car2")
            {
                loseGamePrefab.SetActive(true);
                textWin.GetComponent<Text>().text = "Player 1";
                Time.timeScale = 0f;
            }
        }
    }
}