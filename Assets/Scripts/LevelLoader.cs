using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
    [SerializeField] int timeToWait = 4;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForSec());
        }
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(currentSceneIndex = 1);
    }
    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("Options Screen");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }
}
