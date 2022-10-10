using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class UIAnimation : MonoBehaviour
{
    public Transform MainUIPosition;
    private Animator UIMoveAnimator;

    private void Start()
    {
        UIMoveAnimator = this.GetComponent<Animator>();
    }

    public void canGo()
    {
        if (MainUIPosition.localPosition.x == 0)
        {
            UIMoveAnimator.Play("UI_Animation");
        }
    }

    public void canGoBack()
    {
        if (MainUIPosition.localPosition.x == -622)
        {
            UIMoveAnimator.Play("UI_Animation_Reverse");
        }
    }

    
}
