using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNumber : MonoBehaviour
{
    public int dayNumber;
    public bool clicked = false;
    public void SendDay()
    {
        if (clicked == false)
        {
            clicked = true;
        }
    }
}
