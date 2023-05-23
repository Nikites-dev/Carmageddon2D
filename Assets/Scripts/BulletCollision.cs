using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;

using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

namespace DefaultNamespace
{
    public class BulletCollision : MonoBehaviour
    {
        private Random random = new Random();

        [SerializeField] private GameObject txtHP;
        [SerializeField] private GameObject car2Prefab;
        [SerializeField] private GameObject loseGamePrefab;
        [SerializeField] private GameObject textWin;

        [SerializeField] private GameObject boostButton;
        [SerializeField] private GameObject regenerateButton;
        
        [SerializeField] private GameObject reverseLoadPrefab;

        void Update()
        {
            if (Car2.BonusCount > 0)
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

        IEnumerator TimeEncriese()
        {
            reverseLoadPrefab.SetActive(true);
                yield return new WaitForSeconds(1);
                reverseLoadPrefab.SetActive(false);
        }
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Reverse")
            {
                CarControl.isNormalControl = !CarControl.isNormalControl;
                Destroy(collision.gameObject);
                StartCoroutine(TimeEncriese());
            }

            if (collision.gameObject.tag == "Bonus")
            {
                Car2.BonusCount++;
                Destroy(collision.gameObject);
            }

            else if (collision.gameObject.tag == "Car1")
            {
                Car2.Health -= 15;
                Car1.Health -= 15;
                txtHP.GetComponent<Text>().text = Car2.Health.ToString();
            }

            else if (collision.gameObject.tag != "Train" && collision.gameObject.tag != "Bonus" && collision.gameObject.tag != "Reverse")
            {
                double numRndx = -random.NextDouble() * (0.9 - 0) + 0;
                double numRndy = -random.NextDouble() * (0.5 - 0) + 0;
                car2Prefab.GetComponent<Rigidbody2D>().velocity = new Vector3((float)numRndx, (float)numRndy, 0);

                Car2.Health -= Car1.Damage;

                txtHP.GetComponent<Text>().text = Car2.Health.ToString();
                Destroy(collision.gameObject);
            }

            else if (collision.gameObject.tag == "Train")
            {
                Physics2D.IgnoreCollision(GameObject.FindGameObjectWithTag("Train").GetComponent<Collider2D>(), GetComponent<Collider2D>());
                Car2.Health -= 20;
                txtHP.GetComponent<Text>().text = Car2.Health.ToString();
            }

            if (Car2.Health < 1)
            {
                loseGamePrefab.SetActive(true);
                textWin.GetComponent<Text>().text = "Player 1";
                Time.timeScale = 0f;
            }
        }
    }
    
    
   
}