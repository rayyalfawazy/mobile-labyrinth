using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Outside : MonoBehaviour
{
    [SerializeField] UnityEvent OnBallOut = new UnityEvent();
    [SerializeField] GameObject Ball;

    private void OnCollisionEnter(Collision collision)
    {
        OnBallOut.Invoke();
        Destroy(Ball);
    }
}
