using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance = null;

    AudioSource _audioSource;
    [SerializeField] AudioSource _item;
    [SerializeField] AudioSource _open;
    [SerializeField] AudioSource _inventoryOpen;

    public void Awake()
    {
        #region Singleton Pattern (Simple)
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            _audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
        #endregion
    }
    public void PlaySong(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }

    public void PlayItem(AudioClip clip)
    {
        _item.clip = clip;
        _item.Play();
    }

    public void PlayOpen(AudioClip clip)
    {
        _open.clip = clip;
        _open.Play();
    }

    public void PlayInventoryOpen(AudioClip clip)
    {
        _inventoryOpen.clip = clip;
        _inventoryOpen.Play();

    }
}
