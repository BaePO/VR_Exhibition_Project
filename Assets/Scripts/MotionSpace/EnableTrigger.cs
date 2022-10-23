using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTrigger : MonoBehaviour
{
    public GameObject[] objTrue;
    public GameObject[] objFalse;

    private void OnEnable()
    {
        foreach (GameObject objects in objTrue)
        {
            objects.SetActive(true);
        }

        foreach (GameObject objects in objFalse)
        {
            objects.SetActive(false);
        }
    }
}
