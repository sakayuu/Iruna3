using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private bool clickFlag;

    public bool ClickFlag { get => clickFlag; set => clickFlag = value; }

    public void OnClick()
    {
        clickFlag = true;
    }
}
