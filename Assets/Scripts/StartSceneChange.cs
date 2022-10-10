using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneChange : MonoBehaviour
{
    public void SceneChange()
    {
        if (this.gameObject.name == "GetStart_Button")
        {
            SceneManager.LoadScene("MotionSpace");

        }

        if (this.gameObject.name == "StartButton")
        {
            SceneManager.LoadScene("Room");
        }
    }
}
