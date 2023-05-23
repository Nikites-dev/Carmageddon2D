using Assets.Scripts;
using System;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

namespace DefaultNamespace
{
    public class BulletCollision2:MonoBehaviour
    {
        private Random random = new Random();
        [SerializeField] private GameObject txtHP;
        [SerializeField] private GameObject car1Prefab;
        [SerializeField] private GameObject loseGamePrefab;
        [SerializeField] private GameObject textWin;

        [SerializeField] private GameObject boostButton;
        [SerializeField] private GameObject regenerateButton;

        void Update()
        {
            if (Car1.BonusCount > 0)
            {
                boostButton.SetActive(true);
                regenerateButton.SetActive(true);
            }

            else
            {
                boostButton.SetActive(false);
                regenerateButton.SetActive(false);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Reverse")
            {
                CarControl.isNormalControl = !CarControl.isNormalControl;
            }

            if (collision.gameObject.tag == "Bonus")
            {
                Car1.BonusCount++;
                Destroy(collision.gameObject);
            }

            else if (collision.gameObject.tag == "Car2")
            {
                Car2.Health -= 15;
                Car1.Health -= 15;
                txtHP.GetComponent<Text>().text = Car1.Health.ToString();
            }

            else if (collision.gameObject.tag != "Train" && collision.gameObject.tag != "Bonus")
            {
                int numRndx = random.Next(-9, -3); 
                int numRndy = random.Next(-4, 3); 
                car1Prefab.GetComponent<Rigidbody2D>().velocity = new Vector3(numRndx, numRndy, 0);

                Car1.Health -= Car2.Damage;

                txtHP.GetComponent<Text>().text = Car1.Health.ToString();
                Destroy(collision.gameObject); 
            }

            else if (collision.gameObject.tag == "Train")
            {
                Physics2D.IgnoreCollision( GameObject.FindGameObjectWithTag("Train").GetComponent<Collider2D>(), GetComponent<Collider2D>());
                Car1.Health -= 20;
                txtHP.GetComponent<Text>().text = Car1.Health.ToString();
            }
            
            if (Car1.Health < 1)
            {
                loseGamePrefab.SetActive(true);
                textWin.GetComponent<Text>().text = "Player 2";
                Time.timeScale = 0f;
            }
        }
    }
}