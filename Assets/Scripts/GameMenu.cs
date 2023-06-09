using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    [SerializeField] TMP_Text gameVersion;

    private void Start()
    {
        if (gameVersion != null)
        {
            ShowVersion();
        }
    }

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

    public void GoToCredit()
    {
        SceneManager.LoadScene("EndCredit");
        DOTween.KillAll();
    }

    public void ShowVersion()
    {
        gameVersion.text = $"Version {Application.version}";
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
