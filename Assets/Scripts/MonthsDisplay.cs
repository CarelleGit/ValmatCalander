using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonthsDisplay : MonoBehaviour
{
    public Text monthName;
    public Days daysDisplay;
    public void DisplayMonth(MonthsContainer month)
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
}
