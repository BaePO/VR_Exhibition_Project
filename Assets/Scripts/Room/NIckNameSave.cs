using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NIckNameSave : MonoBehaviour
{
    public static NIckNameSave Instance;

    private string NickName;
    public InputField inputField_NickName;

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
