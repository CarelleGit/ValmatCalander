using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditingMonths : MonoBehaviour
{
    public InputField monthNewName;
    public Text monthName;
    public PanelLerp panel;

    // Use this for initialization
    void Start()
    {
        panel = GetComponentInParent<PanelLerp>();
    }

    public void SaveChanges()
    {       
            monthName.text = monthNewName.text;       
    }
}
