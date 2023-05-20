using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


namespace DefaultNamespace
{
    public class WeatherGenerate: MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private GameObject fogPrefab;
        [SerializeField] private Transform fogPoints;
        private Random random = new Random();
        
        void Start()
        {
           StartCoroutine(TimeEncriese());
        }
        
        IEnumerator TimeEncriese()
        {
            for (int i = 0; i < 999999; i++)
            {
                
                int numWait = random.Next(10, 30);
                
                yield return new WaitForSeconds(numWait);
                
                
                int numSide = random.Next(0, 2);

                if (numSide == 10)
                {
                  
                }
                else
                {
                  //  int numRnd = random.Next(0, listRightPoints.Count);
                    var pos = fogPoints.position;
                    pos.y -= 5.0f;
                   // pos.z = 1366.2f;
                
                    // GameObject warning = Instantiate(warningPrefab, posWarning, listRightPoints[numRnd].rotation);
                    // // train.tag = "Train";

                   // yield return new WaitForSeconds(0.5f);
               
                  //  Destroy(warning);
                    
                    GameObject fog = Instantiate(fogPrefab, pos, fogPoints.rotation);
                    fog.tag = "Fog";
                    
                    fog.GetComponent<Rigidbody2D>().velocity = - fog.transform.right * (_moveSpeed);
                    yield return new WaitForSeconds(6f);
                    
                    Destroy(fog);
                }


            }
        }
    }
}