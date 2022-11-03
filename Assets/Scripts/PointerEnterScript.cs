using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PointerEnterScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private GameObject hideObj;

    private void Awake()
    {
        hideObj = transform.GetChild(0).gameObject;
    }

    private void Start()
    {
        hideObj.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        hideObj.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hideObj.SetActive(false);
    }
}
