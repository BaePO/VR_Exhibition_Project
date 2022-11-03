using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCoroutine : MonoBehaviour
{
    public GameObject text14;
    
    private void Start()
    {
        StartCoroutine(TextWithTime());
    }

    IEnumerator TextWithTime()
    {
        yield return new WaitForSeconds(5.0f);
        text14.SetActive(true);
        StopAllCoroutines();
    }
}
