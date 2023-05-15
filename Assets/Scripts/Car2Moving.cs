using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2Moving:MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
            [SerializeField] private Transform _left;
            [SerializeField] private Transform _right;

            [SerializeField] private Transform _blockBottom;
            
            private int cntTurn = 0;
            
            private Vector2 _direction;
            bool _isTurning = false;
            void Update()
            {
                _moveSpeed = 2f;
                // float horizontalInput = Input.GetAxisRaw("Horizontal");
                // var target = transform.position;
                // target.x += horizontalInput;
                // target.x = Mathf.Clamp(target.x, _left.position.x + _left.localScale.x, _right.position.x - _right.localScale.x);
                // transform.position = Vector3.MoveTowards(transform.position, target, _moveSpeed);
                
                if(_isTurning)
                {
          
                    transform.position = Vector3.MoveTowards(transform.position, _direction, _moveSpeed * Time.deltaTime);
                    
                    if (transform.position.x == _direction.x && transform.position.y == _direction.y)
                    {
                        _isTurning = false;
                    }
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    _direction.x = transform.position.x - 2.2f;
                    _direction.y = transform.position.y;
                    _isTurning = true;
                    cntTurn++;
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    _direction.x = transform.position.x + 2.2f;
                    _direction.y = transform.position.y;
                    _isTurning = true;
                    cntTurn--;
                }
                
                
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    _direction.y = transform.position.y - 2.2f;
                    _direction.x = transform.position.x;
                    _isTurning = true;
                    cntTurn++;
                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    _direction.y = transform.position.y + 2.2f;
                    _direction.x = transform.position.x;
                    _isTurning = true;
                    cntTurn--;
                }
               
            }
            
        
            // [SerializeField] private GameObject _imageCritical;
            private void OnTriggerEnter2D(Collider2D collision)
            {
                Time.timeScale = 0f;
                _blockBottom.gameObject.SetActive(true);
                // _imageCritical.SetActive(true);
                // Destroy(collision.gameObject);
            }
        
        
            private void OnCollisionEnter2D(Collision2D collision)
            {
                //   Destroy(gameObject);
                // _blockBottom.gameObject.SetActive(true);
            }
        }
