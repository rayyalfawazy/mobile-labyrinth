using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMovement : MonoBehaviour
{
    Vector3 initialRotate;

    // Start is called before the first frame update
    void Start()
    {
        initialRotate = Vector3.zero;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        initialRotate.x = -Input.gyro.rotationRateUnbiased.x;
        initialRotate.z = -Input.gyro.rotationRateUnbiased.z;
        transform.Rotate(initialRotate);
    }
}
