using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelControls : MonoBehaviour
{

    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // controls the barrel by rotating on the x axis.
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);
        }
    }
}
