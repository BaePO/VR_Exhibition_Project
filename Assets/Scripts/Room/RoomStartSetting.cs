using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomStartSetting : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject rightHand;

    private void Start()
    {
        leftHand.transform.localPosition = new Vector3(0, 0, 0);
        rightHand.transform.localPosition = new Vector3(0, 0, 0);
    }
}
