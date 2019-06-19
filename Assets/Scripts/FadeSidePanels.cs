using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSidePanels : MonoBehaviour
{
    public CanvasGroup canvas;
    public Animator animator;
    public CanvasGroup parentCanvas;
   
    public void FadePanel()
    {
        if(canvas.alpha <= 0)
        {
            animator.SetTrigger("FadeIn");
        }
        if(canvas.alpha >= 1 )
        {
            animator.SetTrigger("FadeOut");
        }
    }
}
