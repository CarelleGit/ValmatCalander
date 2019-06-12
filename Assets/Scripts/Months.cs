using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Month",menuName ="Add Month",order = 1)]
public class Months : ScriptableObject
{
    public string monthName;
    public int monthNumber;
    public int NumberOfDays;
    public bool isLeapYear;
}
