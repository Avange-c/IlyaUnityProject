using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameConrol : MonoBehaviour
{
    CharacterController Player;
    Vector3 Player_vector;
    float Ver, Hor;
    public float JumpForce, MoveSpeed;
    int Number = 0;
    void Start()
    {
        Player = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        Ver = Input.GetAxis("Vertical");
        Hor = Input.GetAxis("Horizontal");

        if(Player.isGrounded)
        {
            Player_vector = new Vector3(Hor, 0, Ver);
            Player_vector = transform.TransformDirection(Player_vector);
            if(Input.GetAxis("Jump")>0)
            {
                Player_vector.y += JumpForce;
            }
        }
        else
        {
            Player_vector.y -= 0.1f;
        }
        Player.Move(Player_vector*MoveSpeed*Time.deltaTime);
    }

    
}