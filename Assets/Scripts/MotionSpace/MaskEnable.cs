using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaskEnable : MonoBehaviour
{
    public GameObject maskingObj;

    private Mask masking;
    
    private void Start()
    {
        masking = maskingObj.GetComponent<Mask>();       
    }

    public void DoMasking()
    {
        StartCoroutine(MaskWithSeconds());
    }
    IEnumerator MaskWithSeconds()
    {
        yield return new WaitForSeconds(1f);

        if (!masking.enabled)
        {
            masking.enabled = false;
        }
        else
        {
            masking.enabled = true;
        };

        StopAllCoroutines();
    }
}
