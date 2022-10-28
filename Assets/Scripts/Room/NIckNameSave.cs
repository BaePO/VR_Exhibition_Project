using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NIckNameSave : MonoBehaviour
{
    public static NIckNameSave Instance;

    public string NickName;

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
        NickName = GetComponent<Text>().text;
    }
}
