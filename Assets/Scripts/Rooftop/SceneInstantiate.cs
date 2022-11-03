using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInstantiate : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SceneInit());
    }

    IEnumerator SceneInit()
    {
        yield return new WaitForSeconds(15.0f);
        SceneManager.LoadScene("Start");
        StopAllCoroutines();
    }
}
