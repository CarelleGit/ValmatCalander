using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public struct Holidays
{
    public string holidayName;
    public int day;
    public string discription;
}

[CreateAssetMenu(fileName ="Month",menuName ="Add Month",order = 1)]
public class Months : ScriptableObject
{
    public string monthName;
    public List<Holidays> holidays = new List<Holidays>();
    public int monthNumber;
    public int NumberOfDays;
    public bool isLeapYear;
}
