using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Days : MonoBehaviour
{
    public List<Button> buttons = new List<Button>();
    

    void Start()
    {
        buttons.AddRange(GetComponentsInChildren<Button>());
    }
}
