using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Character;

public class GamePlayManager : MonoBehaviour
{
    private Player player = null;
    private CameraManager cameraManager = null;
    [SerializeField]
    private GameObject cameraObj = null;
    [SerializeField]
    private GameObject stage = null;
    [SerializeField]
    public GameObject UI = null;

    void Start()
    {
        Create();
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        player.Update();
        cameraManager.Update(player, MouseClickCheck());
    }

    private void Create()
    {
        cameraManager = new CameraManager(cameraObj);
        player = new Player("マスター", Vector3.up);

    }

    /// <summary>
    /// マウスの入力をチェック
    /// </summary>
    /// <returns>ボタンの判定はインスペクタでやってる</returns>
    private bool MouseClickCheck()
    {
        return UI.transform.GetChild(0).GetChild(2).GetComponent<button>().ClickFlag;
    }

    private void Initialize()
    {
        player.Initialize();
    }
}
