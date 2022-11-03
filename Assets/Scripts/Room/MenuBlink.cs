using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBlink : MonoBehaviour
{
    public GameObject MenuUI;
    public AudioSource blinkSFX;

    void Start()
    {
        StartCoroutine(Blink());    
    }

    IEnumerator Blink()
    {
        while (true)
        {
            MenuUI.SetActive(false);
            yield return new WaitForSeconds(1f);
            MenuUI.SetActive(true);
            blinkSFX.Play();
            yield return new WaitForSeconds(1f);
        }
    }

    public void BlinkStop()
    {
        StopAllCoroutines();
        MenuUI.SetActive(true);
    }
}
