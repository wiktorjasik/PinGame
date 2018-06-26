using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;
    public GameObject spawnButton;

    public Animator animator;

    private void Start()
    {
        Input.simulateMouseWithTouches = enabled;
    }

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;
        spawnButton.SetActive(false);

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("MainLevel");
        Score.score = 0;
        spawnButton.SetActive(true);
    }
}
