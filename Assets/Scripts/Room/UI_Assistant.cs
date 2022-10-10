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
        messageText.text = "���񽺿��� ����Ͻ� �г����� �Է����ּ���.";
        textWriter.AddWriter(messageText, "���񽺿��� ����Ͻ� �г����� �Է����ּ���.", 0.1f);
    }

}
