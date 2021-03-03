using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private bool clickFlag;

    public bool ClickFlag { get => clickFlag; set => SetClickFlag(value); }

    /// <summary>
    /// ボタンが押された時にフラグをtrue
    /// </summary>
    public void OnClick()
    {
        ClickFlag = true;
    }

    /// <summary>
    /// ボタンのリセット(ボタンを押したら必ず呼ぶ)
    /// </summary>
    public void ButtonReset()
    {
        if (ClickFlag)
            ClickFlag = false;
    }

    private void SetClickFlag(bool clickFlag)
    {
        if (this.clickFlag == clickFlag)
            return;
        this.clickFlag = clickFlag;
    }

}
