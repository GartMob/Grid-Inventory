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

}
