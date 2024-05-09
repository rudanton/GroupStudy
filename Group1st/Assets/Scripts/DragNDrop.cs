using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragNDrop : MonoBehaviour, IPointerDownHandler
{
    public MovingImage movingImage;
    private Image _image;
    private void Start()
    {
        movingImage = FindFirstObjectByType<MovingImage>();
        _image = GetComponent<Image>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(gameObject.name);
        movingImage.image.enabled = true;
        movingImage.image.sprite = _image.sprite;
    }
}
