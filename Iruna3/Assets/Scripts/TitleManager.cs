using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField]
    GameObject start = null;
    [SerializeField]
    GameObject credit = null;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void NextSceneLoad(string nextScene) => SceneManager.LoadScene(nextScene);

    public void GamePlaySceneLoad() => NextSceneLoad("CharaChoiceScene");
    
}
