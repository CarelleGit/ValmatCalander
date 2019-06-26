using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DateTracker : MonoBehaviour
{
    public List<MonthsContainer> months;
    
    public Text CurrentDate;
    bool isHoliday;
    public InputField Month, day, year;
    public Button setDate;
    public Text errorMessage;
    bool error = false;
    int currentMaxDays;
  
    int i = 0; //Day
    int j = 0; //month
    int l = 0; //Year

    public ParticleSystem summer;
    public ParticleSystem spring;
    public ParticleSystem autumn;
    public ParticleSystem winter;


    public void SetDate()
    {
        if (Month.text == "" || day.text == "" || year.text == "")
        {
            setDate.interactable = false;
        }
        foreach (MonthsContainer item in months)
        {
            CurrentDate.text = item.month.monthName + "-" + day.text + "-" + year.text;

        }
    }
    public void ActivateButton()
    {
        Int32.TryParse(day.text, out i);
        Int32.TryParse(Month.text, out j);
        Int32.TryParse(year.text, out l);
        if (j > 12)
        {
            errorMessage.text = "There are only 12 months";
            error = false;
        }
        else
        {
            errorMessage.text = "";
            error = true;

            switch (Month.text)
            {
                default:
                case "1":
                    winter.Play();
                    spring.Stop();
                    autumn.Stop();
                    summer.Stop();
                    if (i > 31)
                    {
                        errorMessage.text = "This month contains only 31 days";
                        error = false;
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "2":
                    winter.Play();
                    spring.Stop();
                    autumn.Stop();
                    summer.Stop();
                    if (i > 28)
                    {
                        errorMessage.text = "This month contains only 28 days";
                        error = false;
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "3":
                    winter.Stop();
                    spring.Play();
                    autumn.Stop();
                    summer.Stop();
                    if (i > 31)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 31 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "4":
                    winter.Stop();
                    spring.Play();
                    autumn.Stop();
                    summer.Stop();
                    if (i > 30)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 30 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "5":
                    winter.Stop();
                    spring.Play();
                    autumn.Stop();
                    summer.Stop();
                    if (i > 31)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 31 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "6":
                    winter.Stop();
                    spring.Stop();
                    autumn.Stop();
                    summer.Play();
                    if (i > 30)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 30 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "7":
                    winter.Stop();
                    spring.Stop();
                    autumn.Stop();
                    summer.Play();
                    if (i > 31)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 31 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "8":
                    winter.Stop();
                    spring.Stop();
                    autumn.Stop();
                    summer.Play();
                    if (i > 30)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 30 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "9":
                    winter.Stop();
                    spring.Stop();
                    autumn.Play();
                    summer.Stop();
                    if (i > 31)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 31 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "10":
                    winter.Stop();
                    spring.Stop();
                    autumn.Play();
                    summer.Stop();
                    if (i > 31)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 31 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "11":
                    winter.Stop();
                    spring.Stop();
                    autumn.Play();
                    summer.Stop();
                    if (i > 30)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 30 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
                case "12":
                    winter.Play();
                    spring.Stop();
                    autumn.Stop();
                    summer.Stop();
                    if (i > 31)
                    {
                        error = false;
                        errorMessage.text = "This month contains only 31 days";
                    }
                    else
                    {
                        error = true;
                        errorMessage.text = "";
                    }
                    break;
            }
        }
        if (Month.text != "" && day.text != "" && year.text != "" && error == true)
        {
           
            setDate.interactable = true;
        }
    }

    public void LongRest()
    {
        Int32.TryParse(day.text, out i);
        i++;
        day.text = i.ToString();
        foreach (MonthsContainer item in months)
        {
            if (item.month.monthNumber == j)
            {
                j = item.month.monthNumber;
                currentMaxDays = item.month.NumberOfDays;
                if (item.month.monthNumber == 12 && i == item.month.NumberOfDays + 1)
                {
                    Int32.TryParse(year.text, out l);
                    l++;
                    j = 1;
                    i = 1;
                    Month.text = j.ToString();
                    day.text = i.ToString();
                    year.text = l.ToString();
                }
                switch (item.month.seasons)
                {
                    default:
                    case "Summer":
                        winter.gameObject.SetActive(false);
                        spring.gameObject.SetActive(false);
                        autumn.gameObject.SetActive(false);
                        summer.gameObject.SetActive(true);
                        break;
                    case "Spring":
                        winter.gameObject.SetActive(false);
                        spring.gameObject.SetActive(true);
                        autumn.gameObject.SetActive(false);
                        summer.gameObject.SetActive(false);
                        break;
                    case "Autumn":
                        winter.gameObject.SetActive(false);
                        spring.gameObject.SetActive(false);
                        autumn.gameObject.SetActive(true);
                        summer.gameObject.SetActive(false);
                        break;
                    case "Winter":
                        winter.gameObject.SetActive(true);
                        spring.gameObject.SetActive(false);
                        autumn.gameObject.SetActive(false);
                        summer.gameObject.SetActive(false);
                        break;
                }
                CurrentDate.text = item.month.monthName + "\n" + day.text + "-" + year.text;
            }
        }
        if (i == currentMaxDays + 1)
        {
            j++;
            i = 1;
            day.text = i.ToString();
        }
    }
    void Start()
    {
        setDate.interactable = false;
    } 
}
