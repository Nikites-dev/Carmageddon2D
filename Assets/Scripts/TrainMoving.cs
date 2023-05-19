using UnityEngine;

namespace DefaultNamespace
{
    public class TrainMoving:MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private GameObject trainPrefab;
        [SerializeField] private Transform pointPrefab;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                var pos = pointPrefab.position;
                pos.x -= 6.5f;
                pos.y -= 3.0f;
                
                // Создание объекта пули
                GameObject train = Instantiate(trainPrefab, pos, pointPrefab.rotation);
                
                // Задание скорости пули
                train.GetComponent<Rigidbody2D>().velocity = train.transform.right * _moveSpeed;
            }
        }
    }
}