using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NIckNameSave : MonoBehaviour
{
    public static NIckNameSave Instance;

    private string NickName;
    public TMP_InputField inputField_NickName;

    private void Awake()
    {
        Instance = this;
    }

    /*private void Update()
    {
        Debug.Log(NickName);
    }*/

    public void NIckNameInput()
    {
        NickName = inputField_NickName.text;
    }
}
