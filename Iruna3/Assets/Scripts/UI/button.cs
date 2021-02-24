using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private bool clickFlag;

    public bool ClickFlag { get => clickFlag; set => SetClickFlag(value); }

    public void OnClick()
    {
        clickFlag = true;
    }

    private void SetClickFlag(bool clickFlag)
    {
        if (this.clickFlag == clickFlag)
            return;
        this.clickFlag = clickFlag;

        if (this.clickFlag)
            this.clickFlag = false;
    }
}
