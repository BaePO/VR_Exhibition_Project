using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.transform.name == "Room")
        {
            SceneManager.LoadScene("MotionSpace");
        }
        else if (col.transform.name == "Motion")
        {
            SceneManager.LoadScene("CenterSpace");
        }
        else if (col.transform.name == "Center")
        {
            SceneManager.LoadScene("Rooftop");
        };
    }
}
