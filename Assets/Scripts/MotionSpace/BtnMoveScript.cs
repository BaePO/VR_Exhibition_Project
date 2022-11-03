using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMoveScript : MonoBehaviour
{
    public AnimationCurve xCurve, yCurve;

    private float timeElapsed = 0;
    private bool started = false;

    private float speed;
    private float width;
    private float scale;

    private RectTransform startPosition;


    private void Awake()
    {
        scale = Random.Range(0.7f, 1.4f);
        speed = Random.Range(0.5f, 0.15f);
        width = Random.Range(0.25f, 0.05f);
        startPosition = this.GetComponent<RectTransform>();
        startPosition.anchoredPosition = new Vector2(0.32f, Random.Range(-0.2f, 0.1f));
    }

    private void Start()
    {
        startPosition.localScale = new Vector3(startPosition.localScale.x * scale, startPosition.localScale.y * scale, startPosition.localScale.z);
    }

    private void FixedUpdate()
    {
        if (!started)
        {
            started = true;
            timeElapsed = 0;
            
        }
        else
        {
            // continue
            timeElapsed += Time.deltaTime;

            // Move Prefab position to curve positions at current time
            startPosition.anchoredPosition = new Vector2(startPosition.anchoredPosition.x - xCurve.Evaluate(timeElapsed) * speed,
                 yCurve.Evaluate(timeElapsed) * width);

            if (timeElapsed >= 4)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
