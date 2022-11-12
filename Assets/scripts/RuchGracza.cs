using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchGracza : MonoBehaviour
{
    float yValue = 0;
    [SerializeField] float moveSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
       PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void PrintInstruction()
    {
        Debug.Log("witam");
        Debug.Log("Poruszasz się WASD");
        Debug.Log("dojdz do mety");
    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue); 
    }

}
