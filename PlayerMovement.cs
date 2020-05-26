using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController controller;
    public Transform player;
    public Vector3 firstgame;
    public Vector3 door_position1;
    public float speed = 12.0f;
   
     
    void Update()
    {

        float range = 1.5f;


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        if (Vector3.Distance((player.position), door_position1) < range)
        {
            transform.position = firstgame;
        }
    }


}




