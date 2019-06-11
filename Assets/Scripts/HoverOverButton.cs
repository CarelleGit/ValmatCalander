using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverOverButton : MonoBehaviour
{
    [SerializeField]
    Button button;
    // Use this for initialization
    void Start()
    {
        button = GetComponent<Button>();
        button.interactable = false;
    }
}
