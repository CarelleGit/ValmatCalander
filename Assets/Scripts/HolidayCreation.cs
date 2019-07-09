using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HolidayCreation : MonoBehaviour
{
    public static int SelectedDay;
    public MonthsContainer months;
    public Holidays holiday;
    public InputField holidayName;
    public InputField holidayDiscription;

    public GameObject panalContainor;
    public GameObject prefab;

    public void Create(Days days)
    {
        months = days.selectedMonth;
        months.month.holidays.Add(SetHolidays(days));
    }
    Holidays SetHolidays(Days input)
    {
        holiday.holidayName = holidayName.text;
        holiday.discription = holidayDiscription.text;
        //holiday.day = ;
        holiday.monthNumber = input.selectedMonth.month.monthNumber;
        holiday.day = SelectedDay;
        return holiday;
        
    }

    public void CreateHolidays()
    {
        GameObject temp;
        temp = Instantiate(prefab);
        temp.transform.SetParent(panalContainor.gameObject.transform);
    }

}
