using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : Command
{
    private float xAxis;
    private float zAxis;
    private CharacterController characterController;
    private Attributes attributes;
    private Transform rootPlayer;

    public Movement()
    {
        characterController=GameObject.FindObjectOfType<CharacterController>();
        rootPlayer = characterController.transform;
        attributes = characterController.GetComponentInChildren<Attributes>();
    }
    public override void Execute()
    {
        xAxis = Input.GetAxis("Horizontal");
        zAxis = Input.GetAxis("Vertical");
        characterController.Move(Calculate);
    }

    private Vector3 Calculate
    {
        get { return (rootPlayer.right * xAxis + rootPlayer.forward * zAxis) * attributes.speed * Time.deltaTime; }
    }
}