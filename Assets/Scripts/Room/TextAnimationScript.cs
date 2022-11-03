using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using JoshH.UI;

public class TextAnimationScript : MonoBehaviour
{
    // private int idx = 0;

    // private Vector2 startPosition;
    // private Vector2 endPosition;

    // private float y_pos1;
    // private float y_pos2;

    // public Button nextBtn;
    public Button backBtn;

    // private GameObject text1;
    // private GameObject text2;
    // private GameObject text3;
    // private GameObject text4;

    // float gap;
    // bool lerp = false;

    // float lerpTime = 0.7f;
    // float currentTime = 0;

    private void Start()
    {
        /*if (this.gameObject.name.Contains("Room"))
        {
            gap = 25.0f;
        }
        else if (this.gameObject.name.Contains("Motion"))
        {
            gap = 15.0f;
        }
        else if (this.gameObject.name.Contains("Center"))
        {
            gap = 17.0f;
        };

        nextBtn.onClick.AddListener(() =>
        {
            nextBtn.enabled = false;
            currentTime = 0;

            // 처음으로 UI 등장
            if (idx == 0) // 0 - down1, 1 - active(true)
            {
                lerp = true;

                text1 = transform.GetChild(idx).gameObject;
                y_pos1 = text1.GetComponent<RectTransform>().anchoredPosition.y;
                y_pos2 = y_pos1 - gap;

                text2 = transform.GetChild(idx + 1).gameObject;
                StartCoroutine(textSetActiveTrue(text2));
            }

            // UI 2개
            else if (idx == 1) // 0 - down2 + alpha, 1 - down1, 2 - active(true)
            {
                lerp = true;

                text1 = transform.GetChild(idx - 1).gameObject;
                y_pos1 = text1.GetComponent<RectTransform>().anchoredPosition.y;
                y_pos2 = y_pos1 - gap;
                text1.GetComponent<UIGradient>().enabled = true;

                text2 = transform.GetChild(idx).gameObject;

                text3 = transform.GetChild(idx + 1).gameObject;
                StartCoroutine(textSetActiveTrue(text3));
            }

            // UI 3개 - 이후 공통
            else // 0 - active(false), 1 - down2 + alpha, 2 - down1, 3 - active(true)
            {
                lerp = true;

                text1 = transform.GetChild(idx - 2).gameObject;
                y_pos1 = text1.GetComponent<RectTransform>().anchoredPosition.y;
                y_pos2 = y_pos1 - gap;
                text1.SetActive(false);

                text2 = transform.GetChild(idx - 1).gameObject;
                text2.GetComponent<UIGradient>().enabled = true;

                text3 = transform.GetChild(idx).gameObject;

                text4 = transform.GetChild(idx + 1).gameObject;
                StartCoroutine(textSetActiveTrue(text4));
            };

            idx++;

        });
        */

        backBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Start");
            NIckNameSave.Instance.NickName = ""; // 닉네임 초기화
        });
    }

    /*private void Update()
    {
        if (lerp)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= lerpTime)
            {
                currentTime = lerpTime;
                nextBtn.enabled = true;
                lerp = false;
            }
            else
            {
                float t = currentTime / lerpTime;

                text1.GetComponent<RectTransform>().anchoredPosition = new Vector2(text1.GetComponent<RectTransform>().anchoredPosition.x, Mathf.Lerp(y_pos1, y_pos2, t*t));

                // text1.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPosition, endPosition, t * t);
                if (idx >= 1)
                {
                    text2.GetComponent<RectTransform>().anchoredPosition = new Vector2(text2.GetComponent<RectTransform>().anchoredPosition.x, Mathf.Lerp(y_pos1 + gap, y_pos2 + gap, t * t));

                    // text2.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPosition + new Vector2(0, 25.0f), endPosition + new Vector2(0, 25.0f), t * t);
                };

                if (idx >= 2)
                {
                    text3.GetComponent<RectTransform>().anchoredPosition = new Vector2(text3.GetComponent<RectTransform>().anchoredPosition.x, Mathf.Lerp(y_pos1 + gap * 2, y_pos2 + gap * 2, t * t));

                    // text3.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPosition + new Vector2(0, 50.0f), endPosition + new Vector2(0, 50.0f), t * t);
                };
            };
        }
        else
        {

        };
    }*/

    IEnumerator textSetActiveTrue(GameObject txt)
    {
        yield return new WaitForSeconds(0.8f);
        txt.SetActive(true);
        StopAllCoroutines();
    }
}
