using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
    }
}
