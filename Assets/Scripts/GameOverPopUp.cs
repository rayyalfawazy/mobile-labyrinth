using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverPopUp : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] string fill;
    void Start()
    {
        text.text = fill;
        text.transform.DOScale(Vector3.one,2f)
            .SetEase(Ease.OutElastic); 
    }
}
