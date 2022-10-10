using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VideoTimeScript : MonoBehaviour
{
    private float timer = 0;
    public TMP_Text timer_text;

    public void startTimer()
    {
        StartCoroutine(TimeAdd());    
    }

    protected IEnumerator TimeAdd()
    {
        while (timer < 14)
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
        StopAllCoroutines();
    }
}
