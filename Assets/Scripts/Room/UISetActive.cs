using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISetActive : MonoBehaviour
{
    public GameObject UI_ActiveTrue = null;
    public GameObject UI_ActiveFalse = null;

    private void OnEnable()
    {   
        if (UI_ActiveTrue != null) {
            UI_ActiveTrue.SetActive(true);
        }

        if (UI_ActiveFalse != null)
        {
            UI_ActiveFalse.SetActive(false);
        }
    }

    private void OnDisable()
    {
        if (UI_ActiveTrue != null)
        {
            UI_ActiveTrue.SetActive(false);
        }

        if (UI_ActiveFalse != null)
        {
            UI_ActiveFalse.SetActive(true);
        }
    }
}
