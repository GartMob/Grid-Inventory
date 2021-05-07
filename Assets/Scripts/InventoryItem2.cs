using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;


public class InventoryItem2 : EventTrigger
{
    [SerializeField] AudioClip _inventoryOpen;

    private bool dragging;
    private Vector2 offset;

    private Grid grid;
    private MainMenuController controller;

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
    }

    private void Start()
    {
        if(_inventoryOpen != null)
        {
            AudioManager.Instance.PlaySong(_inventoryOpen);
        }
    }

    public void Update()
    {
        if (dragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        dragging = true;
        offset = eventData.position - new Vector2(transform.position.x, transform.position.y);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        dragging = false;
        SnapToGrid(offset);
    }

    private void SnapToGrid(Vector3 release)
    {
        var position = grid.GetNearestPointOnGrid(release);
            //(
           // Mathf.RoundToInt(this.transform.position.x),
           // Mathf.RoundToInt(this.transform.position.y),
           // Mathf.RoundToInt(this.transform.position.z)
           // );


        this.transform.position = position;
    }
}
