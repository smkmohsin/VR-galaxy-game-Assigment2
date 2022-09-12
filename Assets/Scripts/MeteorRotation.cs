using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorRotation : MonoBehaviour
{
    public float rotationSpeed = 5.0f;
    public float rotationDeg = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(rotationDeg * Time.deltaTime * rotationSpeed, rotationDeg * Time.deltaTime * rotationSpeed, rotationDeg * Time.deltaTime * rotationSpeed);
    }
}
