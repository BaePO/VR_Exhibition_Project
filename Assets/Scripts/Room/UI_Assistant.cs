using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Assistant : MonoBehaviour
{
    [SerializeField] private TextScript textWriter;
    private TMP_Text messageText;

    private void Awake()
    {
        messageText = this.gameObject.GetComponent<TMP_Text>();
    }
    private void Start()
    {
        messageText.text = "서비스에서 사용하실 닉네임을 입력해주세요.";
        textWriter.AddWriter(messageText, "서비스에서 사용하실 닉네임을 입력해주세요.", 0.1f);
    }

}
