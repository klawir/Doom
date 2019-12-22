using Player.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public GameObject playerObj;
    private CharacterController characterController;
    private Attributes player;

    private Command movement;

    private void Start()
    {
        player = playerObj.GetComponent<Attributes>();
        characterController = playerObj.GetComponent<CharacterController>();

        movement = new Movement(playerObj);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            movement.Execute();
    }
}