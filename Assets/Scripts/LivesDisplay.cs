using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lives = 10;
    Text livesText;


    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }
    public void TakeLife()
    {
        lives--;
        UpdateDisplay();
        CheckIfLose();
    }

    private void CheckIfLose()
    {
        if (lives <= 0 )
        {
            FindObjectOfType<LevelLoader>().LoadGameOver();
        }
    }
}
