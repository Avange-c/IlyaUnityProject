using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove: MonoBehaviour
{
    private float xRot;
    private float yRot;
    public Camera player;
    public GameObject playerGameObject;
    public float sensivity = 5f;

    void Update()
    {
        Mouse_Move();
    }

    void Mouse_Move()
    {
        xRot += Input.GetAxis("Mouse X");
        yRot += Input.GetAxis("Mouse Y");

        player.transform.rotation = Quaternion.Euler(-yRot, xRot, 0f);
        playerGameObject.transform.rotation = Quaternion.Euler(0f, xRot, 0f);


    }
}
