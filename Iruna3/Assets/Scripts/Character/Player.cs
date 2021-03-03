using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Data;

public class Player : Character
{
    private Status status;
    private Vector3 velocity;
    private float moveSpeed = 0.01f;

    private float speed = 2;

    public Player(string name, Vector3 pos)
    {
        this.name = name;
        this.pos = pos;
    }

    public void Initialize()
    {
        ModelLoad(out model, "Models", "TestModel");
    }

    public void Update()
    {
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        SetVelocity(ref velocity);

        pos += FixedDirection() * speed;
        ModelMove(pos);
    }

    private void ModelMove(in Vector3 pos)
    {
        model.transform.position = pos;
        if (FixedDirection() != Vector3.zero)
            model.transform.rotation = Quaternion.LookRotation(FixedDirection());
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
    public GameObject GetPlayerModel() => model;

    /// <summary>
    /// 入力から計算して移動量をセット
    /// </summary>
    /// <param name="velocity">セット先</param>
    private void SetVelocity(ref Vector3 velocity)
    {
        velocity = Vector3.zero;
        float moveFix = 1;

        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.S))
            if(Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
                moveFix = 0.71f;

        if (Input.GetKey(KeyCode.W))
            velocity.z = moveSpeed * moveFix;
        if (Input.GetKey(KeyCode.S))
            velocity.z = -moveSpeed * moveFix;
        if (Input.GetKey(KeyCode.A))
            velocity.x = -moveSpeed * moveFix;
        if (Input.GetKey(KeyCode.D))
            velocity.x = moveSpeed * moveFix;
    }

    public Vector3 FixedDirection()
    {
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        Vector3 moveFoward = cameraForward * velocity.z + Camera.main.transform.right * velocity.x;

        return moveFoward;
    }

}
