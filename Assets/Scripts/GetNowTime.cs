using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

public class GetNowTime : MonoBehaviour
{
    private TMP_Text timeText;

    private void Awake()
    {
        timeText = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        StartCoroutine(GetTime());
    }

    IEnumerator GetTime()
    {
        yield return new WaitForSeconds(1f);
        timeText.text = DateTime.Now.ToString("hh:mm tt", CultureInfo.CreateSpecificCulture("en-US"));
    }
}
