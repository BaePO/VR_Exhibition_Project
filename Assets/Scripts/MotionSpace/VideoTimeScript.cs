using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VideoTimeScript : MonoBehaviour
{
    private float timer = 0;
    public TMP_Text timer_text;

    public GameObject VideoUI;
    public GameObject VideoUI2;
    public GameObject teleportVFX;
    public GameObject text9;
    public GameObject text10;

    public void startTimer()
    {
        StartCoroutine(TimeAdd());    
    }

    protected IEnumerator TimeAdd()
    {
        while (timer < 48)
        {
            timer++;
            if (timer < 10)
            {
                timer_text.text = $"00:0{timer}";
            }
            else
            {
                timer_text.text = $"00:{timer}";
            }
            yield return new WaitForSeconds(1f);
        }
        VideoUI.SetActive(false);
        VideoUI2.SetActive(false);
        teleportVFX.SetActive(true);
        text9.SetActive(false);
        text10.SetActive(true);
        StopAllCoroutines();
    }
}
