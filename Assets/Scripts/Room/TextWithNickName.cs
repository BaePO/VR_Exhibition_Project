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
        if (gameObject.name.Contains("Room1"))
        {
            textField.text = $"안녕하세요 {NIckNameSave.Instance.NickName}님 Motro에 오신 것을 진심으로 환영합니다!";
        }
        else if (gameObject.name.Contains("Room2"))
        {
            textField.text = $"예약 페이지에서 {NIckNameSave.Instance.NickName}님이 \n 수강하셨던 채널과 수강하기를 원하는 \n 운동 콘텐츠를 찾아보실 수 있어요.";
        }
        else if (gameObject.name.Contains("Motion"))
        {
            textField.text = $"{NIckNameSave.Instance.NickName}님 즐거운 운동 되셨나요?";
        }
    }
}
