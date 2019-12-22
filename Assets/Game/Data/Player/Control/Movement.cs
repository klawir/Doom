using Player.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : Command
{
    private float x;
    private float z;
    private Vector3 pos;
    private CharacterController characterController;
    private Attributes player;

    public Movement(GameObject playerObj)
    {
        player = playerObj.GetComponent<Attributes>();
        characterController = playerObj.GetComponent<CharacterController>();
    }
    public override void Execute()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        pos = player.transform.right * x + player.transform.forward * z;
        characterController.Move(pos * player.speed * Time.deltaTime);
    }
}