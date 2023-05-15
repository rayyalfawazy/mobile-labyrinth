using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] CoinData coinData;
    [SerializeField] MeshRenderer coinRenderer;

    public int GetScoreAddition { get => coinData.scoreAddition; }

    void Start()
    {
        Animate();
        coinRenderer.material = coinData.material;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(gameObject);
            DOTween.KillAll();
        }
    }

    public void Animate()
    {
        transform.DORotate(new Vector3(0, 180, 0), 1)
            .SetLoops(-1)
            .SetRelative()
            .SetEase(Ease.Linear);
    }
}
