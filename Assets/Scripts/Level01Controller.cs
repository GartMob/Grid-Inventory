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

    }
    public void ExitLevel()
    {
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
