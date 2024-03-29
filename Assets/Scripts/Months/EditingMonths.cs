﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditingMonths : MonoBehaviour
{
    public InputField monthNewName;
    public Text monthName;
    public PanelLerp panel;
    public MonthsContainer months;

    // Use this for initialization
    void Start()
    {
        panel = GetComponentInParent<PanelLerp>();
        monthName.text = months.month.monthName;
        if(monthName.text == "")
        {
            monthName.text = "Please Name";
        }
       if(monthName.text == "Please Name")
        {

            monthNewName.text = "Please Name";
        }
    }

    public void SaveChanges()
    {
        months.month.monthName = monthNewName.text;
        monthName.text = months.month.monthName;       
    }
}
