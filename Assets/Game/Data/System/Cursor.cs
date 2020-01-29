using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public static void Hide()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }
}