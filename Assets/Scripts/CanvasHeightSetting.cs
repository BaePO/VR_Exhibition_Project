using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasHeightSetting : MonoBehaviour
{
    public RectTransform canvas;
    public GameObject player;

    private void Start()
    {
        float playerHeight = player.transform.position.y;
        canvas.anchoredPosition = new Vector2(canvas.anchoredPosition.x, playerHeight);
    }
}
