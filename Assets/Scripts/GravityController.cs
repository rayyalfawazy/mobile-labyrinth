using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    [SerializeField] float acceleration = 9.8f;
    Vector3 gravityOffset;
    bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            isActive = true;
        }
        CalibrateGravity();
    }

    void Update()
    {
        if (isActive) 
        {
            Physics.gravity = GetGravityFromSensor() - gravityOffset;
        }
        else
        {
            Physics.gravity = Vector3.zero;
        }
    }

    public void SetActive(bool value)
    {
        isActive = value;
        if (value)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    public void CalibrateGravity()
    {
        gravityOffset = GetGravityFromSensor() - Vector3.down * acceleration;
    }

    public Vector3 GetGravityFromSensor()
    {
        Vector3 gravity;
        if (Input.gyro.gravity != Vector3.zero)
        {
            gravity = Input.gyro.gravity * acceleration;
        }
        else
        {
            gravity = Input.acceleration * acceleration;
        }
        gravity.z = Mathf.Clamp(gravity.z, float.MinValue, -1);
        return new Vector3(gravity.x, gravity.z, gravity.y);
    }
}
