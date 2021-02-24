using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private GameObject playerModel = null;

    public Player(string name, Vector3 pos)
    {
        this.name = name;
        this.pos = pos;
    }

    public void Initialize()
    {
        playerModel = (GameObject)Resources.Load("Models/TestModel");
        playerModel = GameObject.Instantiate(playerModel, pos, Quaternion.identity);
    }

    public void Update()
    {
        Move();
    }

    public void Move()
    {
        if (Input.GetKey(KeyCode.W))
            pos.z += 0.01f;
        if (Input.GetKey(KeyCode.A))
            pos.x -= 0.01f;
        if (Input.GetKey(KeyCode.S))
            pos.z -= 0.01f;
        if (Input.GetKey(KeyCode.D))
            pos.x += 0.01f;
        ModelMove(pos);
    }

    private void ModelMove(in Vector3 pos)
    {
        playerModel.transform.position = pos;
    }

    public void UseSkill()
    {

    }

    public void Buff()
    {

    }

    public void DeBuff()
    {

    }

    public override Vector3 GetPos() => base.GetPos();
    public GameObject GetPlayerModel() => playerModel;
    
}
