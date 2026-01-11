using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed;
    public float run_speed;
    
    float currentSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        CubeMove();
    }

    void CubeMove()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = run_speed;
        }
        else if (!(Input.GetKey(KeyCode.LeftShift)))
        {
            currentSpeed = speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (Vector3.forward * Time.deltaTime * currentSpeed);
            print(currentSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (Vector3.back * Time.deltaTime * currentSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (Vector3.right * Time.deltaTime * currentSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (Vector3.left * Time.deltaTime * currentSpeed);
        }
    }
}