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
                    bool isMove = false;
                    if (transform.position.x - 2.2f > 5.7 && transform.position.x - 2.2f < 11.5)
                    {
                        _direction.x = transform.position.x - 2.2f;
                        isMove = true;
                    }
                    else
                    {
                        if (transform.position.x - 1f > 5.7 && transform.position.x - 1f < 11.5)
                        {
                            _direction.x = transform.position.x - 1f;
                            isMove = true;
                        }
                        else
                        {
                            if (transform.position.x - 0.5f > 5.7 && transform.position.x - 0.5f < 11.5)
                            {
                                _direction.x = transform.position.x - 0.5f;
                                isMove = true;
                            }
                        }
                    }
                    
                    if (isMove)
                    {
                        _direction.y = transform.position.y;
                        _isTurning = true;
                    }
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    bool isMove = false;
                    if (transform.position.x + 2.2f > 5.7 && transform.position.x + 2.2f < 11.5)
                    {
                        _direction.x = transform.position.x + 2.2f;
                        isMove = true;
                    }
                    else
                    {
                        if (transform.position.x + 1f > 5.7 && transform.position.x + 1f < 11.5)
                        {
                            _direction.x = transform.position.x + 1f;
                            isMove = true;
                        }
                        else
                        {
                            if (transform.position.x + 0.5f > 5.7 && transform.position.x + 0.5f < 11.5)
                            {
                                _direction.x = transform.position.x + 0.5f;
                                isMove = true;
                            }
                        }
                    }
                    
                    if (isMove)
                    {
                        _direction.y = transform.position.y;
                        _isTurning = true;
                    }
                }
                
                
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    bool isMove = false;
                    if (transform.position.y - 2.2f > -3 && transform.position.y - 2.2f < 3.3)
                    {
                        _direction.y = transform.position.y - 2.2f;
                        isMove = true;
                    }
                    else
                    {
                        if (transform.position.y - 1f > -3 && transform.position.y - 1f < 3.3)
                        {
                            _direction.y = transform.position.y - 1f;
                            isMove = true;
                        }
                        else
                        {
                            if (transform.position.y - 0.3f > -3 && transform.position.y - 1f < 3.3)
                            {
                                _direction.y = transform.position.y - 0.3f;
                                isMove = true;
                            }
                        }
                    }

                    if (isMove)
                    {
                        _direction.x = transform.position.x;
                        _isTurning = true;
                    }


                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    bool isMove = false;
                    if (transform.position.y + 2.2f > -3 && transform.position.y + 2.2f < 3.3)
                    {
                        _direction.y = transform.position.y + 2.2f;
                        isMove = true;
                    }
                    else
                    {
                        if (transform.position.y + 1f > -4 && transform.position.y + 1f < 3.3)
                        {
                            _direction.y = transform.position.y + 1f;
                            isMove = true;
                        }
                        else
                        {
                            if (transform.position.y + 0.3f > -4 && transform.position.y + 0.3f < 3.3)
                            {
                                _direction.y = transform.position.y + 0.3f;
                                isMove = true;
                            }
                        }
                    }

                    if (isMove)
                    {
                        _direction.x = transform.position.x;
                        _isTurning = true;
                    }
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
