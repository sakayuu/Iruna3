using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager
{
    private GameObject cameraObj = null;
    //カメラの回転速度
    public float rotateSpeed = 30f;
    //カメラの視点制限
    private const float ANGLE_LIMIT_UP = 60f;
    private const float ANGLE_LIMIT_DOWN = -10f;


    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="cameraObj">シーン上のカメラ</param>
    public CameraManager(GameObject cameraObj)
    {
        this.cameraObj = cameraObj;
    }

    public void Update(Player player, bool rotateCameraFlag)
    {
        CameraMove(player.GetPos());

        CameraRotation(rotateCameraFlag);

    }

    /// <summary>
    /// カメラの座標移動
    /// </summary>
    /// <param name="pos">追従用座標</param>
    private void CameraMove(in Vector3 pos)
    {
        cameraObj.transform.position = pos;
    }

    /// <summary>
    /// カメラの回転移動
    /// </summary>
    /// <param name="rotateCameraFlag">回転させるか</param>
    private void CameraRotation(in bool rotateCameraFlag)
    {
        if (!rotateCameraFlag)
            return;
        RotateCameraAngle();

        float angle_x = 180f <= cameraObj.transform.eulerAngles.x ? cameraObj.transform.eulerAngles.x - 360 : cameraObj.transform.eulerAngles.x;
        cameraObj.transform.eulerAngles = new Vector3(
            Mathf.Clamp(angle_x, ANGLE_LIMIT_DOWN, ANGLE_LIMIT_UP),
            cameraObj.transform.eulerAngles.y,
            cameraObj.transform.eulerAngles.z);
    }

    /// <summary>
    /// マウスの移動量を回転に変換
    /// </summary>
    private void RotateCameraAngle()
    {
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        cameraObj.transform.eulerAngles += new Vector3(angle.y, angle.x);
    }
}
