using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{

    public GameObject endGameMenuUI;
    public GameObject pauseMenuButton;
    public GameObject spawner;

    public void EndGame()
    {
        endGameMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void HidePauseButton()
    {
        pauseMenuButton.SetActive(false);
        spawner.SetActive(false);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        endGameMenuUI.SetActive(false);
        pauseMenuButton.SetActive(true);
        spawner.SetActive(true);
        Score.score = 0;
        Time.timeScale = 1f;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("MainLevel");
        endGameMenuUI.SetActive(true);
        pauseMenuButton.SetActive(true);
        spawner.SetActive(true);
        Score.score = 0;
        Time.timeScale = 1f;
    }
}
