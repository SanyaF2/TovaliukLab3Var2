using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public GameObject obj;
    private float rotationSpeed = 90.0f;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            obj.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Destroy(obj);
        }
    }
}
