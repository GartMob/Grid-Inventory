using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] AudioClip _pickUp;
    [SerializeField] AudioClip _putDown;
    [SerializeField] AudioClip _inventoryOpen;
    [SerializeField] Text _highScoreTextView;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        if(_inventoryOpen != null)
        {
            AudioManager.Instance.PlaySong(_inventoryOpen);
        }
    }

    public void doExitGame()
    {
        Application.Quit();
    }

    public void PlayPickUp()
    {
        if (_pickUp != null)
        {
            AudioManager.Instance.PlaySong(_pickUp);
        }
    }

    public void PlayPutDown()
    {
        if (_putDown != null)
        {
            AudioManager.Instance.PlaySong(_putDown);
        }
    }
    
}
