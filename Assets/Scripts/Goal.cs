using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    [SerializeField] UnityEvent OnGoal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Ball is Goal");
            OnGoal.Invoke();
        }
    }
}
