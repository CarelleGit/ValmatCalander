using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Days : MonoBehaviour
{
    public List<Button> buttons = new List<Button>();

    public MonthsContainer selectedMonth;

    void Start()
    {
        buttons.AddRange(GetComponentsInChildren<Button>());
    }

    public void UpdateSelectedMonth(MonthsContainer input)
    {
        selectedMonth = input;
    }
    
}
