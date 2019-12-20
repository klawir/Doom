using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensivity;
    private float mouseX;
    private float mouseY;
    private float xRotation;
    public Transform player;

    private void Start()
    {
        System.Cursor.Hide();
    }
    private void Update()
    {
        Calculate();
        Rotate();
    }
    private void Rotate()
    {
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
    private void Calculate()
    {
        mouseX = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
}