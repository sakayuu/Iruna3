using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager
{
    private Camera camera;
    private Vector3 offset;


    public CameraManager(Camera camera)
    {
        this.camera = camera;
    }

    public void Update(Player player)
    {
        CameraMove(player.GetPos());
        CameraRotation(player.GetPlayerModel().transform.position);
        offset = camera.transform.position - player.GetPos();
        
    }

    private void CameraMove(Vector3 pos)
    {
        camera.transform.position = pos + offset;
    }

    private void CameraRotation(Vector3 pos)
    {
        if (Input.GetKey(KeyCode.UpArrow))
            camera.transform.RotateAround(pos, camera.transform.right, 0.1f);
        if (Input.GetKey(KeyCode.DownArrow))
            camera.transform.RotateAround(pos, camera.transform.right, -0.1f);
        if (Input.GetKey(KeyCode.LeftArrow))
            camera.transform.RotateAround(pos, Vector3.up, -0.1f);
        if (Input.GetKey(KeyCode.RightArrow))
            camera.transform.RotateAround(pos, Vector3.up, 0.1f);
        offset = camera.transform.position - pos;
    }
}
