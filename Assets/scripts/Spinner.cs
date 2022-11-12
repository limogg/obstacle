using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xRot;
    [SerializeField] float yRot;
    [SerializeField] float zRot;

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(xRot, yRot, zRot);  
    }
}
