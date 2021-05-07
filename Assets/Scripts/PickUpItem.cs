using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{

    [SerializeField] GameObject _visualsToDeactivate = null;
    [SerializeField] GameObject _visualsToEnable = null;

    Collider _colliderToDeactivate = null;

    private void Start()
    {
        _visualsToEnable.SetActive(false);
    }

    private void Awake()
    {
        _colliderToDeactivate = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement player
            = other.gameObject.GetComponent<PlayerMovement>();

        if (player != null)
        {
            gameObject.GetComponent<Canvas>();
            Cursor.lockState = CursorLockMode.None;
            EnableObject();
        }
    }

    public void DisableObject()
    {
        _colliderToDeactivate.enabled = false;

        _visualsToDeactivate.SetActive(false);
    }

    public void EnableObject()
    {
        _visualsToEnable.SetActive(true);
    }
}
