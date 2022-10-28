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
            textField.text = $"�ȳ��ϼ��� {NIckNameSave.Instance.NickName}�� Motro�� ���� ���� �������� ȯ���մϴ�!";
        }
        else if (gameObject.name.Contains("Motion"))
        {
            textField.text = $"{NIckNameSave.Instance.NickName}�� ��ſ� � �Ǽ̳���?";
        }
    }
}
