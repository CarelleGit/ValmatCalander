using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitching : MonoBehaviour
{
    private Animator currentAnimator;
    public void Start()
    {
        currentAnimator = GetComponent<Animator>();
    }
    public void SwitchingCanvas(Animator nextAnimator)
    {
    }
}
