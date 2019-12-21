using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed;

    public void Move(Transform cameraTransform)
    {
        projectile.velocity = cameraTransform.forward * speed;
    }
}