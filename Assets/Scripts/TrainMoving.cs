using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

namespace DefaultNamespace
{
    public class TrainMoving:MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private GameObject trainPrefab;
        [SerializeField] private GameObject warningPrefab;
        [SerializeField] private List<Transform> listLeftPoints;
        [SerializeField] private List<Transform> listRightPoints;
        private Random random = new Random();

        void Start()
        {
            StartCoroutine(TimeEncriese());
        }

        void Update()
        {
            
        }

        IEnumerator TimeEncriese()
        {
            for (int i = 0; i < 999999; i++)
            {
                int numWait = random.Next(10, 30);
                
                yield return new WaitForSeconds(numWait);
                
                
                int numSide = random.Next(0, 2);

                if (numSide == 1)
                {
                    int numRnd = random.Next(0, listLeftPoints.Count);
                    var pos = listLeftPoints[numRnd].position;
                    pos.x -= 6.5f;
                    pos.y -= 2.0f;
                
                    var posWarning = listLeftPoints[numRnd].position;
                    posWarning.x = -8.0f;
                  //  posWarning.z = 0f;
                    // pos.y -= 2.0f;
                
                    GameObject warning = Instantiate(warningPrefab, posWarning, listLeftPoints[numRnd].rotation);
                    // train.tag = "Train";

                    yield return new WaitForSeconds(0.5f);
               
                    Destroy(warning);
               
                    // Создание объекта пули
                    GameObject train = Instantiate(trainPrefab, pos, listLeftPoints[numRnd].rotation);
                    train.tag = "Train";
                
                    // Задание скорости пули
                    train.GetComponent<Rigidbody2D>().velocity = train.transform.right * _moveSpeed;
            
            
                    yield return new WaitForSeconds(10f);
                }
                else
                {
                    int numRnd = random.Next(0, listRightPoints.Count);
                    var pos = listRightPoints[numRnd].position;
                    pos.x -= 6.5f;
                    pos.y -= 2.0f;
                
                    var posWarning = listRightPoints[numRnd].position;
                    posWarning.x = 8.3f;
                 //   posWarning.z = 0f;
                    // pos.y -= 2.0f;
                
                    GameObject warning = Instantiate(warningPrefab, posWarning, listRightPoints[numRnd].rotation);
                    // train.tag = "Train";

                    yield return new WaitForSeconds(0.8f);
               
                    Destroy(warning);
                    
                    GameObject train = Instantiate(trainPrefab, pos, listRightPoints[numRnd].rotation);
                    train.tag = "Train";
                    
                    train.GetComponent<Rigidbody2D>().velocity = - train.transform.right * (_moveSpeed);
                    
                }


            }
        }
    }
}