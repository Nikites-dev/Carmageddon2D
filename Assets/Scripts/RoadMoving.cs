 using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoving : MonoBehaviour
{
    [SerializeField] private Transform roadPrefab;
    
    public float speed = 10;

    private float distance = 19f; //2f
    
    public float startX;
    // public float endY;   


    private void Start()
    {
        roadPrefab.position = new Vector3(startX, roadPrefab.position.y, roadPrefab.position.z);

    }


    void Update ()
    {
        roadPrefab.position += new Vector3(-speed * Time.deltaTime, 0f , 0f);
        //roadPrefab.Translate(Vector2.down * speed * Time.deltaTime);
        if (roadPrefab.position.x < startX - distance) {
            roadPrefab.position = new Vector3(startX, roadPrefab.position.y, roadPrefab.position.z);
        }
        
        
        
        if (Input.GetKey(KeyCode.W))
        {
            speedReg("+");

        }
                
        if (Input.GetKey(KeyCode.S))
        {
            speedReg("-");

        }
                
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speedReg("+");

        }
                
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speedReg("-");

        }
    }

    public void speedReg(String regular)
    {
        if (speed >= 0)
        {
            if (regular == "+")
            {
                speed += 0.01f;
            }
            else if (regular == "-")
            {
                speed -= 0.01f; 
            }
        }
        else
        {
            speed = 0;
        }
    }
    
}
