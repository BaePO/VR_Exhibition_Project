using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextWithNickName : MonoBehaviour
{
    private TMP_Text textField;
    
    private void Awake()
    {
        textField = GetComponentInChildren<TMP_Text>();
    }

    void Start()
    {
        if (gameObject.name.Contains("Room"))
        {
            textField.text = $"안녕하세요 {NIckNameSave.Instance.NickName}님 Motro에 오신 것을 진심으로 환영합니다!";
        }
        else if (gameObject.name.Contains("Motion"))
        {
            textField.text = $"{NIckNameSave.Instance.NickName}님 즐거운 운동 되셨나요?";
        }
    }
}
