using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarMoving : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private GameObject carPrefab;

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

        if (_isTurning)
        {
            transform.position = Vector3.MoveTowards(transform.position, _direction, _moveSpeed * Time.deltaTime);

            if (transform.position.x == _direction.x && transform.position.y == _direction.y)
            {
                _isTurning = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            bool isMove = false;
            if (transform.position.x - 2.2f > -7 && transform.position.x - 2.2f < 0.6)
            {
                _direction.x = transform.position.x - 2.2f;
                isMove = true;
            }
            else
            {
                if (transform.position.x - 1f > -7 && transform.position.x - 1f < 0.6)
                {
                    _direction.x = transform.position.x - 1f;
                    isMove = true;
                }
            }

            if (isMove)
            {
                _direction.y = transform.position.y;
                _isTurning = true;
                carPrefab.GetComponent<Rigidbody2D>().velocity = new Vector3(-1, 0, 0);
            }
            else
            {
                carPrefab.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            bool isMove = false;
            if (transform.position.x + 2.2f > -7 && transform.position.x + 2.2f < 0.6)
            {
                _direction.x = transform.position.x + 2.2f;
                isMove = true;
            }
            else
            {
                if (transform.position.x + 1f > -7 && transform.position.x + 1f < 0.6)
                {
                    _direction.x = transform.position.x + 1f;
                    isMove = true;
                }
            }

            if (isMove)
            {
                _direction.y = transform.position.y;
                _isTurning = true;
                carPrefab.GetComponent<Rigidbody2D>().velocity = new Vector3(1, 0, 0);
            }
            else
            {
                carPrefab.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            bool isMove = false;
            if (transform.position.y - 2.2f > -4.7 && transform.position.y - 2.2f < 1)
            {
                _direction.y = transform.position.y - 2.2f;
                isMove = true;
            }
            else
            {
                if (transform.position.y - 1f > -4.7 && transform.position.y - 1f < 1)
                {
                    _direction.y = transform.position.y - 1f;
                    isMove = true;
                }
                else
                {
                    if (transform.position.y - 0.3f > -4.7 && transform.position.y - 1f < 1)
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
                carPrefab.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            bool isMove = false;
            if (transform.position.y + 2.2f > -4.7 && transform.position.y + 2.2f < 1.5)
            {
                _direction.y = transform.position.y + 2.2f;
                isMove = true;
            }
            else
            {
                if (transform.position.y + 1f > -4.7 && transform.position.y + 1f < 1.5)
                {
                    _direction.y = transform.position.y + 1f;
                    isMove = true;
                }
                else
                {
                    if (transform.position.y + 0.3f > -4.7 && transform.position.y + 0.3f < 1.5)
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
                carPrefab.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
        }

        if (transform.position.x > -7 && transform.position.x < 0.6)
        {
        }
        else
        {
            carPrefab.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
    }


    // [SerializeField] private GameObject _imageCritical;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
        //  _blockBottom.gameObject.SetActive(true);
        // _imageCritical.SetActive(true);
        // Destroy(collision.gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //   Destroy(gameObject);
        // _blockBottom.gameObject.SetActive(true);
    }
}