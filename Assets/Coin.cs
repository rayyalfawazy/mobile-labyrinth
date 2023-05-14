using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    [SerializeField] UnityEvent OnBallEnter = new UnityEvent();

    void Start()
    {
        transform.DORotate(new Vector3(0,180,0), 1)
            .SetLoops(-1)
            .SetRelative()
            .SetEase(Ease.Linear);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(gameObject);
            OnBallEnter.Invoke();
        }
    }
}
