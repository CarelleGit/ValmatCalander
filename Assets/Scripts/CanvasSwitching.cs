using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitching : MonoBehaviour
{
    private Animator currentAnimator;
    private CanvasGroup canvas;
    public CanvasGroup currentCanvas;
    public void Start()
    {
        currentAnimator = GetComponent<Animator>();
        canvas = GetComponent<CanvasGroup>();
    }
    public void SwitchingCanvas()
    {
        if (canvas.alpha >= 1)
        {
            currentAnimator.SetBool("FadeOut", true);
            currentAnimator.SetBool("FadeIn", false);
            currentCanvas.interactable = true;
            currentCanvas.blocksRaycasts = true;
            canvas.interactable = false;
            canvas.blocksRaycasts = false;
        }
        if(canvas.alpha <= 0)
        {
            currentAnimator.SetBool("FadeOut", false);
            currentAnimator.SetBool("FadeIn", true);
            currentCanvas.interactable = false;
            currentCanvas.blocksRaycasts = false;
            canvas.interactable = true;
            canvas.blocksRaycasts = true;
        }
    }
}
