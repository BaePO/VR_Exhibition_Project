using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnInstantiate : MonoBehaviour
{
    public GameObject heartPrefab;
    public GameObject parentUI;

    public void InstantiatePrefab()
    {
        GameObject heart = Instantiate(heartPrefab, parentUI.transform);
        
    }
}
