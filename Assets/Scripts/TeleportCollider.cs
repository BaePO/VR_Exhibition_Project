using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportCollider : MonoBehaviour
{
    public bool fadeStart = true;
    public float fadeDuration = 2;
    public Color fadeColor;
    public Renderer rend;

    private void Start()
    {
        if (fadeStart)
        {
            FadeIn();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        StartCoroutine(SceneChange(col));
    }
    
    public void FadeIn()
    {
        Fade(1, 0);
    }

    public void FadeOut()
    {
        rend.enabled = true;
        Fade(0, 1);
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;
        rend.material.SetColor("_Color", newColor2);
        rend.enabled = false;
    }

    public IEnumerator SceneChange(Collider col)
    {
        FadeOut();
        yield return new WaitForSeconds(fadeDuration);

        if (col.transform.name == "Room")
        {
            SceneManager.LoadScene("CenterSpace");
        }
        else if (col.transform.name == "Motion")
        {
            SceneManager.LoadScene("Room2");
        }
        else if (col.transform.name == "Center")
        {
            SceneManager.LoadScene("Start");
        };
    }
}
