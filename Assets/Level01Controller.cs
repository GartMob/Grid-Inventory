using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level01Controller : MonoBehaviour
{
    [SerializeField] Text _currentScoreTextView;
    [SerializeField] Text _currentHealthTextView;
    [SerializeField] GameObject enemy;

    int _currentScore;
    int _currentHealth;


    PlayerMovement other;
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitLevel();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            DecreaseHealth(-50);
        }

    }
    public void ExitLevel()
    {
        int highScore = PlayerPrefs.GetInt("HighScore");
        if (_currentScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", _currentScore);
            Debug.Log("New high score: " + _currentScore);
        }
        SceneManager.LoadScene("MainMenu");
    }

    public void IncreaseScore(int scoreIncrease)
    {
        _currentScore += scoreIncrease;

        _currentScoreTextView.text =
            "Score: " + _currentScore.ToString();
    }

    public void DecreaseHealth(int healthDecrease)
    {
        _currentHealth -= healthDecrease;

        _currentHealthTextView.text =
            "Health: " + _currentHealth.ToString();
    }
}
