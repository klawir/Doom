using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    private Command movement;

    private void Start()
    {
        movement = new Movement();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.D))
            movement.Execute();
    }
}