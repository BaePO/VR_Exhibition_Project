using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{
    private TMP_Text uiText;
    private string textToWrite;
    private int characterIndex;
    private float timePerCharacter;
    private float timer;

    public void AddWriter(TMP_Text uiText, string textToWrite, float timePerCharacter)
    {
        this.uiText = uiText;
        this.textToWrite = textToWrite;
        this.timePerCharacter = timePerCharacter;
        characterIndex = 0;
    }

    private void Update()
    {
        if (uiText != null)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                // Display next character
                timer += timePerCharacter;
                characterIndex++;
                uiText.text = textToWrite.Substring(0, characterIndex);

                if (characterIndex >= textToWrite.Length)
                {
                    // Entire string displayed
                    uiText = null;
                    return;
                }
            }
        }
    }
}
