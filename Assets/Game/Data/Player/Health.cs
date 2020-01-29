using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text gui;
    public int amount;

    public void Remove(int dmg)
    {
        amount -= dmg;
    }
    public void Add(int value)
    {
        amount += value;
    }

}