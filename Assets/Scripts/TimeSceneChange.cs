using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeSceneChange : MonoBehaviour
{
    private Transform playerTr;

    private Vector3 startPos;

    bool checking = false;
    Coroutine lastRoutine = null;

    private void Start()
    {
        playerTr = GetComponent<Transform>();

        startPos = transform.position;

        StartCoroutine(InputCheck());
    }

    IEnumerator InputCheck()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);

            if (playerTr.position == startPos)
            {
                if (!checking)
                {
                    lastRoutine = StartCoroutine(TimeCheck());
                }
            }
            else
            {
                startPos = playerTr.position;
                checking = false;
                StopCoroutine(lastRoutine);
            }
        }        
    }
    IEnumerator TimeCheck()
    {
        checking = true;
        yield return new WaitForSeconds(300.0f);

        SceneManager.LoadScene("Start");
    }
}
