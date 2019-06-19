using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitching : MonoBehaviour
{
    public Animator currentAnimator;
    public CanvasGroup canvas;
    public CanvasGroup nextCanvas;
    public void Start()
    {
       
    }
    public void SwitchingCanvas()
    {
        if (canvas.alpha >= 1)
        {
            currentAnimator.SetTrigger("FadeOut");
            nextCanvas.interactable = true;
            nextCanvas.blocksRaycasts = true;
            canvas.interactable = false;
            canvas.blocksRaycasts = false;
        }
        if(canvas.alpha <= 0)
        {
            currentAnimator.SetTrigger("FadeIn");
            nextCanvas.interactable = false;
            nextCanvas.blocksRaycasts = false;
            canvas.interactable = true;
            canvas.blocksRaycasts = true;
        }
    }
}
