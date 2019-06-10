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

    // Update is called once per frame
    private void OnMouseEnter()
    {
        button.interactable = true;
    }

    private void OnMouseExit()
    {
        button.interactable = false;
    }
}
