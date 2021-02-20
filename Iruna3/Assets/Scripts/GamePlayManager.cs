using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    [SerializeField, Header("プレイヤー")]
    public GameObject player;
    [SerializeField, Header("UI")]
    public GameObject UI;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player.GetComponent<Player>().Update();
    }
}
