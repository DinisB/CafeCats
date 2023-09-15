using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGameWhenClicked : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Game");

    }

    public void SkipIntro()
    {
        SceneManager.LoadScene("Title");
    }

    public void Convert()
    {
        SceneManager.LoadScene("ConvertPlayerPrefs");

    }

    public void GoToForkliftMinigame()
    {
        SceneManager.LoadScene("ForkliftMinigame");

    }
}
