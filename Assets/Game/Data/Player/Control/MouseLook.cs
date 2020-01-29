using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensivity;
    private float mouseX;
    private float mouseY;
    private float xRotation;
    private Transform player;

    private void Start()
    {
        Cursor.Hide();
        player=GameObject.FindObjectOfType<CharacterController>().transform;
    }
    private void Update()
    {
        if(IsDetectedMovement)
        {
            Calculate();
            Rotate();
        }
    }

    private void Rotate()
    {
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
    private void Calculate()
    {
        mouseX *= sensivity;
        mouseY *= sensivity;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
    private bool IsDetectedMovement
    {
        get 
        {
            mouseX = Input.GetAxis("Mouse X");
            mouseY = Input.GetAxis("Mouse Y");
            return mouseX < 0 || mouseX > 0 ||
                mouseY < 0 || mouseY > 0;
        }
    }
}