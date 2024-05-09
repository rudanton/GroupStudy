using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropImage : MonoBehaviour
{
    public MovingImage movingImage;
    private Image _image;
    private float width;
    private float height;
    private void Start()
    {
        movingImage = FindFirstObjectByType<MovingImage>();
        _image = GetComponent<Image>();
        width = _image.rectTransform.rect.width;
        height = _image.rectTransform.rect.height;
        width /= 2;
        height /= 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var tPos = transform.position;
            var mPos = Input.mousePosition;
            var xBound = mPos.x > tPos.x - width && mPos.x < tPos.x + width;
            var yBound = mPos.y > tPos.y - height && mPos.y < tPos.y + height;


            if (xBound && yBound)
            {
                _image.sprite = movingImage.image.sprite;
            }
        }
    }
}
