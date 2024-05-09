using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MovingImage : MonoBehaviour, IPointerUpHandler
{
    public Image image;
    private void Start()
    {
        image = GetComponent<Image>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Up");
            image.enabled = false;
        }
        if (!image.enabled) return;

        transform.position = Input.mousePosition;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Up");
        image.enabled = false;
    }
}
