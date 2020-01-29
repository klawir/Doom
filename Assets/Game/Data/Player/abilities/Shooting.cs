using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Bullet bullet;
    public Transform rifleBarrel;
    public Transform cameraTransform;
    
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet, rifleBarrel.position, bullet.transform.rotation).Move(cameraTransform);
        }
    }
}
