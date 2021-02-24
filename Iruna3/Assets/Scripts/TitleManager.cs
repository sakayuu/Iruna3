using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField, Header("スタート")]
    GameObject start;
    [SerializeField, Header("クレジット")]
    GameObject credit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ButtonCheck();
    }

    void ButtonCheck()
    {
        if (start.GetComponent<button>().ClickFlag)
        {
            SceneManager.LoadScene("CharaChoiceScene");
            start.GetComponent<button>().ClickFlag = false;
            Debug.Log(start.GetComponent<button>().ClickFlag);
        }
    }
}
