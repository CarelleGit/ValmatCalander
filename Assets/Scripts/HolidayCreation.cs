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
    public Text buttonText;

    public RectTransform centerPoint;

    public List<GameObject> addedHolidays = new List<GameObject>();

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
        buttonText.text = holidayName.text;
        GameObject temp;
        temp = Instantiate(prefab, panalContainor.gameObject.transform);
        temp.GetComponent<RectTransform>().localScale = prefab.GetComponent<RectTransform>().localScale;
        addedHolidays.Add(temp);
        //temp.transform.SetParent(panalContainor.gameObject.transform, false);
    }

    public void AddedHolidays(Days input)
    {
        int i = 0;

        foreach (Holidays item in input.selectedMonth.month.holidays)
        {
            if (item.day == SelectedDay && item.monthNumber == input.selectedMonth.month.monthNumber)
            {
                buttonText.text = input.selectedMonth.month.holidays[i].holidayName;
                GameObject temp;
                temp = Instantiate(prefab, panalContainor.gameObject.transform);
                temp.GetComponent<RectTransform>().localScale = prefab.GetComponent<RectTransform>().localScale;
                temp.GetComponentInChildren<FadeSidePanels>().transform.GetComponent<RectTransform>().anchoredPosition = centerPoint.position;
                addedHolidays.Add(temp);
            }
            i++;
        }
    }
    public void DeleteHolidays()
    {
        foreach (GameObject item in addedHolidays)
        {
            Destroy(item);
        }
        addedHolidays.Clear();
    }

}
