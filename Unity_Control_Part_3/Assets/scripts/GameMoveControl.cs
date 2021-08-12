using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMoveControl : MonoBehaviour
{
    public float speed_Move;
    float x_Move;
    float z_Move;
    CharacterController player;
    Vector3 moveDirection;
    
    void Start()
    {
        player = GetComponent<CharacterController>();
    }
    void Update()
    {
        Move(); 
    }
    void Move()
    {
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        moveDirection = new Vector3(x_Move, 0f, z_Move);
        moveDirection = transform.TransformDirection(moveDirection);
        player.Move(moveDirection * speed_Move * Time.deltaTime);
    }
}
