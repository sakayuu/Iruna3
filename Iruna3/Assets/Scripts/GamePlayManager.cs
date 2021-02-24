using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    private Player player = null;
    private CameraManager camera = null;
    [SerializeField, Header("UI")]
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
        camera.Update(player);
    }

    private void Create()
    {
        camera = new CameraManager(Camera.main);
        player = new Player("マスター",Vector3.up);

    }

    private void Initialize()
    {
        player.Initialize();
    }
}
