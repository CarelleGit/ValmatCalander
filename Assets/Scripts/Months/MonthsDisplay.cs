using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonthsDisplay : MonoBehaviour
{
    public Text monthName;
    public Text DateDisplay;
    public Days daysDisplay;
    private int clickedDay;
    public MonthsContainer month;
    public List<DayNumber> dayNumber = new List<DayNumber>();
    private void Start()
    {
        //month = GetComponent<MonthsContainer>();
    }
    public void DisplayMonth()
    {
        for (int i = 0; i < daysDisplay.buttons.Count; i++)
        {
            daysDisplay.buttons[i].interactable = true;
        }
        monthName.text = month.month.monthName;
       

        if (daysDisplay.buttons.Count > month.month.NumberOfDays)
        {

            for (int i = 0; i < daysDisplay.buttons.Count - month.month.NumberOfDays; i++)
            {
                daysDisplay.buttons[i + month.month.NumberOfDays].interactable = false;
            }

        }
    }
    public void SelectedDateDisplay( Days input)
    { 
        month = input.selectedMonth;
        for (int i = 0; i < dayNumber.Count; i++)
        {
            if (dayNumber[i].clicked == true)
            {
                //Debug.Log("I made it!!!");
                DateDisplay.text = month.month.monthNumber + "-" + dayNumber[i].dayNumber;
                dayNumber[i].clicked = false;
            }
        }
    }

}
