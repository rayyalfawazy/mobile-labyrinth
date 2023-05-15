using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void GoToLevel(string level)
    {
        if (level != "") 
        {
            SceneManager.LoadScene($"Level {level}");
            DOTween.KillAll();
        } else
        {
            BackToMenu();
        }
    }

    public void Retry()
    {
        var currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
        DOTween.KillAll();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
        DOTween.KillAll();
    }
}
