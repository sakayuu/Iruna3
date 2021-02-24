using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private bool clickFlag;

    public bool ClickFlag { get => GetClickFlag(clickFlag); set => SetClickFlag(value); }

    public void OnClick()
    {
        ClickFlag = true;
    }

    private void SetClickFlag(bool clickFlag)
    {
        if (this.clickFlag == clickFlag)
            return;
        this.clickFlag = clickFlag;
    }

    private bool GetClickFlag(bool clickFlag)
    {
        if(clickFlag)
        {
            clickFlag = false;
            return true;
        }
        return clickFlag;
    }
}
